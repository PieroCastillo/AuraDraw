using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using System;

namespace AuraDraw.App
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            
        }
        private void InitializeComponent()
        {
            
            AvaloniaXamlLoader.Load(this);
        }
    }
}
