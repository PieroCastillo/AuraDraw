using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;

namespace AuraDraw.App.UIExtensions
{
    public class ShapeContextMenu : ContextMenu
    {
        public ShapeContextMenu()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public Shape ShapeToEdit
        {
            get { return GetValue(ShapeToEditProperty); }
            set { SetValue(ShapeToEditProperty, value); }
        }
        public readonly static StyledProperty<Shape> ShapeToEditProperty =
            AvaloniaProperty.Register<ShapeContextMenu, Shape>(nameof(ShapeToEdit));
    }
}
