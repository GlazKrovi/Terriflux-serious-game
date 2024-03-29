using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Terriflux.Programs;

/// <summary>
/// guides the following classes: IRound,IGrid, IImpacts, PlacementList
/// </summary>
public partial class PlaceMediator : IPlaceMediator
{
    public static readonly Vector2I UNVALID_COORDINATES = new(-1, -1);

    private readonly IGrid grid;
    private readonly PlacementList placementList;
    private readonly IImpacts impacts;
    private readonly IRound round;
    private readonly IInventory inventory;

    // info about placement status
    private Vector2I wantedCoordinates;     // where to place the cell
    private Building wantedForBuild;               // what it will places
    private readonly List<Building> builtThisTurn;
    private readonly Dictionary<Vector2I, Warehouse> allWarehouses;


    public PlaceMediator(IGrid grid, PlacementList placementList, IImpacts impacts, IRound round, IInventory inventory) 
    {
        this.grid = grid;
        this.placementList = placementList;
        this.round = round;
        this.impacts = impacts;
        this.inventory = inventory;
        this.wantedCoordinates = UNVALID_COORDINATES;
        this.wantedForBuild = null;
        this.builtThisTurn = new();
        this.allWarehouses = new();
    }

    public void Notify(IPlaceMediator sender)
    {
        // react
        switch (sender)
        {
            case PlacementList:
                wantedForBuild = (Building)placementList.GetSelectedItem();
                break;
            case IGrid:
                wantedCoordinates = grid.GetSelectedCoordinates();
                break;
            case Round:
                ReactOnNextRound();
                break;
            default:
                break;
        }

        // try place
        Place();
    }

    private void ResetWants()
    {
        wantedForBuild = null;
        wantedCoordinates = UNVALID_COORDINATES;
    }

    private void ReactOnNextRound()
    {
        // possible change of turn?
        bool isOk = inventory.TryImportExport();    // import export works
        GD.Print(isOk);
        if (isOk == false)  // non
        {
            round.Notify(this);
        }
        else
        {
            // update impacts
            foreach (Building building in builtThisTurn)
            {
                double[] addedValues = building.GetImpacts();
                impacts.IncrementsSocial(addedValues[0]);
                impacts.IncrementsEconomy(addedValues[1]);
                impacts.IncrementsEcology(addedValues[2]);
            }

            // update inventory
            ProcessingExchanges();

            // reset
            ResetWants();
            builtThisTurn.Clear();
        }
    }

    /// <summary>
    /// Confirm the placement and update the grid. <br></br>
    /// If it's a building: adds it to the nearest warehouse, if it's in its area of effect. <br></br>
    /// If it's a warehouse: searches for buildings in its zone and adds them.  
    /// </summary>
    private void Place() {
        if (wantedForBuild != null && wantedCoordinates != UNVALID_COORDINATES)
        {
            ManageCellCrush();
            ManageWarehousePlacement();
            grid.SetAt(wantedCoordinates, wantedForBuild, true);

            // notify colleague
            grid.Notify(this);
            placementList.Notify(this);

            // save a clone has builtThisTurn
            builtThisTurn.Add((Building) RawNode.Instantiate(wantedForBuild.GetType().Name));

            // reset
            ResetWants();
        }
    }   

    private void ManageWarehousePlacement()
    {
        // is an warehouse? add his neighbours already on map
        if (wantedForBuild is Warehouse warehouse)
        {
            foreach (Building build in grid.GetAllOfType<Building>())
            {
                int distanceWithWarehouse = grid.DistanceBewteen(wantedCoordinates, grid.GetCoordinatesOf(build));

                // if in its area of effect... add as a neighbours
                if (distanceWithWarehouse <= Warehouse.EFFECT_ZONE_SIZE)
                {
                    warehouse.AddNeighbour(build);
                }
            }

            // save into warehouse list
            this.allWarehouses.Add(wantedCoordinates, warehouse);
        }
        // is just a building
        else
        {
            foreach (KeyValuePair<Vector2I, Warehouse> kvp in this.allWarehouses)
            {
                int distanceWithWarehouse = grid.DistanceBewteen(wantedCoordinates, kvp.Key);

                // if in its area of effect... add as a neighbours
                if (distanceWithWarehouse <= Warehouse.EFFECT_ZONE_SIZE)
                {
                    kvp.Value.AddNeighbour(wantedForBuild);
                }
            }
        }
    }

    /// <summary>
    /// Handles building supply from warehouses and production storage.
    /// </summary>
    private void ProcessingExchanges()
    {
        List<Building> alreadyProcessed = new();

        // each warehouse on the grid...
        foreach (Warehouse warehouse in allWarehouses.Values)
        {
            // ... requests to its neighbours...
            foreach (Building neighbour in warehouse.GetNeighbours())
            {
                bool isSupplied = true;

                // already been treated? 
                if (alreadyProcessed.Contains(neighbour))
                {
                    isSupplied = false; // yes, skip
                }

                // ... what they needs...
                for (int i = 0; i < neighbour.GetNeeds().Length && isSupplied; i++)
                {
                    // ... can we supply it with enough?
                    if (!(inventory.GetQuantityOf(neighbour.GetNeeds()[i]) >= neighbour.GetNeedOf(neighbour.GetNeeds()[i]))) // no
                    {
                        isSupplied = false;
                    }
                }

                // do we actually supply it?
                if (isSupplied)
                {
                    // we give it ressources
                    for (int i = 0; i < neighbour.GetNeeds().Length && isSupplied; i++)
                    {
                        inventory.Remove(neighbour.GetNeeds()[i], neighbour.GetNeedOf(neighbour.GetNeeds()[i]));
                    }

                    // and we get his production!
                    foreach (FlowKind product in neighbour.GetProduction())
                    {
                        inventory.Add(product, neighbour.GetProductOf(product));
                    }
                }
                // no : does nothing
            }
        }
    }

    private void RemoveFromAllWarehouse(Building removedBuilding)
    {
        foreach (Warehouse warehouse in allWarehouses.Values)
        {
            warehouse.RemoveNeighbour(removedBuilding);
        }
    }

    /// <summary>
    /// If a warehouse is deleted in the operation: deletes its references. <br></br>
    /// If a building is deleted in the operation: deletes it from all warehouses.
    /// </summary>
    private void ManageCellCrush()
    {
        if (grid.GetAt(wantedCoordinates) is Warehouse)
        {
            this.allWarehouses.Remove(wantedCoordinates);
        }
        else if (grid.GetAt(wantedCoordinates) is Building removedBuilding)
        {
            RemoveFromAllWarehouse(removedBuilding);
        }
    }
}