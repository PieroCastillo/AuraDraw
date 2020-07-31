using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Avalonia.Media;
using ThemeEditor.Controls.ColorPicker;
using Avalonia.Controls.Primitives;
using Aura.UI.UIExtensions;
using Aura.UI.Controls;

namespace AuraDraw.App.Views
{
    public class MainView : UserControl
    {
        Grid grid_c;
        TabControl maintabcontrol;
        ColorPicker colorPicker_;
        PropertiesView propertiesView_;
        public MainView()
        {
            InitializeComponent();
            grid_c = this.Find<Grid>("grid_c");
            maintabcontrol = this.Find<TabControl>("MainTabControl");
            colorPicker_ = this.Find<ColorPicker>("colorpicker_");
            propertiesView_ = this.Find<PropertiesView>("propertiesVW_");
            AppData.SetMainWorkSpace(maintabcontrol);
            colorPicker_.PropertyChanged += ColorPicker__PropertyChanged;

            AppData.MainWorkSpace.AddTab(new AuraTabItem()
            {
                Content = new HomePage(),
                Header = "Página de Inicio"
            },true);
        }

        private async void ColorPicker__PropertyChanged(object sender, AvaloniaPropertyChangedEventArgs e)
        {
             await AppData.SetGlobalColor(new SolidColorBrush(colorPicker_.Color));
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