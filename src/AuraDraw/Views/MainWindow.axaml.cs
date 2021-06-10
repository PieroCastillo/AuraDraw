using Aura.UI.Controls;
using Aura.UI.UIExtensions;
using AuraDraw.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Templates;
using System;

namespace AuraDraw.Views
{
    public class MainWindow : Window
    {
        public static AuraTabView tab_m;
        protected double desired_;
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
