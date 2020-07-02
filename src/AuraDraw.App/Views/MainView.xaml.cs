using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AuraDraw.App.Views
{
    public class MainView : UserControl
    {
        Grid grid_c;
        TabControl maintabcontrol;
        public MainView()
        {
            InitializeComponent();
            grid_c = this.Find<Grid>("grid_c");
            maintabcontrol = this.Find<TabControl>("MainTabControl");
            AppData.SetMainWorkSpace(maintabcontrol);
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