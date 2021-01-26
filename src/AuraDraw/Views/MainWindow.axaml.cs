using Aura.UI.Controls;
using Aura.UI.UIExtensions;
using AuraDraw.Managers;
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
            Border b = this.Find<Border>("b_");
            b.PointerPressed += (sender, e) =>
            {
                this.BeginMoveDrag(e);
            };

            MainWindowViewModel.title_ = "AuraDraw";

            tab_m = this.Find<AuraTabView>("tabvw_");
            tab_m.AddTab(TabManager.CreateHomeView(), true);

        }
      
    }
}
