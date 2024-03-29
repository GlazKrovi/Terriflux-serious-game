using Godot;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Terriflux.Programs
{
    public interface IGrid : IPlaceMediator, ICellObserver
    {
        /// <returns>The size of the grid.</returns>
        Vector2I GetDimensions();

        /// <summary>
        /// Retrieves the reference of all grid cells.
        /// </summary>
        /// <returns> Reference of all grid cells.</returns>
        ICell[,] GetAll();

        /// <summary>
        /// Retrieves the cell reference at the specified coordinates.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        ICell GetAt(Vector2I coordinates);

        /// <summary>
        /// Replaces the cell at the specified coordinates.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <param name="cell"></param>
        void SetAt(Vector2I coordinates, ICell cell, bool callForUpdate = true);

        int DistanceBewteen(Vector2I position1, Vector2I position2);

        /// <typeparam name="T">Class derived from ICell.</typeparam>
        /// <returns>All cells of the specified type.</returns>
        T[] GetAllOfType<T>() where T : ICell;

        Vector2I GetSelectedCoordinates();

        Vector2I GetCoordinatesOf(ICell cell);
    }
}