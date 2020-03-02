using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dock.Avalonia.Controls;

namespace AuraDraw.App.Views
{
    public class MainWindow : Window
    {
        DockControl dock;
        public MainWindow()
        {
            InitializeComponent();
            dock = this.Find<DockControl>("dock");
            dock.Height = this.Height - 20;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}