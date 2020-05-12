using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;
using AuraDraw.App.Functions;
using AuraDraw.App.UIExtensions;

namespace AuraDraw.App.Views
{
    public class MainView : UserControl
    {
        Grid grid_c;
        public MainView()
        {
            InitializeComponent();
            grid_c = this.Find<Grid>("grid_c");
        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


        public Window WindowParent
        {
            get { return GetValue(WindowParentProperty); }
            set { SetValue(WindowParentProperty, value); }
        }
        public static readonly StyledProperty<Window> WindowParentProperty =
            AvaloniaProperty.Register<MainView, Window>(nameof(WindowParent));
    }
}