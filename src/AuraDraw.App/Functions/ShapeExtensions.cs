using Avalonia.Controls.Shapes;
using System;
using Avalonia;
using Avalonia.Controls;
using ThemeEditor.Controls.ColorPicker;
using Avalonia.Media;
using Avalonia.Controls.Primitives;
using Avalonia.Collections;
using AuraDraw.App.UIExtensions;

namespace AuraDraw.App.Functions
{
    public static class ShapeExtensions
    {
        public static void AddContextMenu(this Shape shape)
        {
            shape.ContextMenu = new ShapeContextMenu();
        }

    }
}
