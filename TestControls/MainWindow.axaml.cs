using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TestControls
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            App.Manager.EnableLanguages(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
