using Godot;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terriflux.Programs;
/// <summary>
/// Abstract node
/// </summary>
public partial class Cell : RawNode, ICell
{
    private static readonly Texture2D DEFAULT_TEXTURE = GD.Load<Texture2D>(PATH_IMAGES + "grass.png");
    private static readonly Vector2I SIZE = new(128, 128);

    private List<ICellObserver> observers;

    // children
    private TextureButton body;
    private Sprite2D selectedMark;
    private Label nameLabel;

    protected Cell() : base() { this.observers = new(); }
    public override void _Ready()
    {
        base._Ready();
        // congig button
        this.body = GetNode<TextureButton>("Button");
        this.body.TextureNormal = DEFAULT_TEXTURE;
        this.body.Size = SIZE;
        this.body.Show();
        // config name hud
        this.nameLabel = GetNode<Label>("Name");
        this.nameLabel.Text = this.GetType().Name;
        this.nameLabel.Hide();
        // config selection hud
        this.selectedMark = GetNode<Sprite2D>("SelectedMark");
        this.selectedMark.Texture = GD.Load<Texture2D>(PATH_IMAGES + "willchange.png");
        this.selectedMark.Scale = new(4, 4);
        this.selectedMark.Hide();
        // scale
        this.Scale = new((float)0.1, (float)0.1);
    }

    protected void ChangeSkin(Texture2D texture)
    {
        this.body.TextureNormal = texture;
    }

    public Vector2I GetDimensions()
    {
        Vector2I gapCorrector = new(26, 26);
        return (SIZE) - gapCorrector;
    }

    public bool IsSelected()
    {
        return this.selectedMark.Visible;
    }

    public void Select()
    {
        this.selectedMark.Show();
        Notify();
    }

    public void Unselect()
    {
        this.selectedMark.Hide();
    }
    private void OnMouseAbove() { this.nameLabel.Show(); }
    private void OnMouseOutside() { this.nameLabel.Hide(); }
    private void OnPressed()
    {
        if (IsSelected()) Unselect();
        else Select();
    }

    public override string Verbose()
    {
        StringBuilder sb = new();
        sb.Append(base.Verbose());
        sb.AppendLine($"Size: {SIZE}");
        sb.AppendLine($"Cell body texture: {this.body.TextureNormal}");
        sb.AppendLine($"Is actually selected: {IsSelected()}");
        return sb.ToString();
    }

    /// <summary>
    /// Notifies its grid that it, the cell, has been selected.
    /// </summary>
    private void Notify()
    {
        foreach (ICellObserver observer in this.observers)
        {
            observer.Update(this);
        }
    }

    public void AddObserver(ICellObserver observer)
    {
        if (observers.Contains(observer)) return;
        else this.observers.Add(observer);
    }

    public void RemoveObserver(ICellObserver observer)
    {
        if (!observers.Contains(observer)) return;
        else this.observers.Remove(observer);
    }
}
