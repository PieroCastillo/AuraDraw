using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Collections;
using Avalonia.VisualTree;

public static class PanelExtensions
{
    public static void AddControlOnAPoint(this Panel panel, Control control, Point location)
    {
        control.Margin = new Thickness(location.X, location.Y);
        panel.Children.Add(control);
    }
}