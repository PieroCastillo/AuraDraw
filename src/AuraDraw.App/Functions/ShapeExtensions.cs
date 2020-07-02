using AuraDraw.App.UIExtensions;
using Avalonia.Controls.Shapes;

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
