using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Jaya.Shared.Controls;

namespace AuraDraw.App
{
    public class MainWindow : StyledWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}