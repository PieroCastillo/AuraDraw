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
    public class MainWindow : ContentWindow
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
            Border bb = this.Find<Border>("bb_");
            b.PointerPressed += (sender, e) =>
            {
                this.BeginMoveDrag(e);
            };
            Grid g_ = this.Find<Grid>("grid_");
            //g_.PointerPressed += (sender, e) =>
            //{
            //    this.BeginResizeDrag(WindowEdge.South, e);
            //};

            MainWindowViewModel.title_ = "AuraDraw";

            tab_m = this.Find<AuraTabView>("tabvw_");
            tab_m.AddTab(TabManager.CreateHomeView(), true);

            //tab_m.TemplateApplied += (sender, e) =>
            //{
            //    this.desired_ = DesiredSizeForDragBorderLeft(e, tab_m);
            //};
            // var border = this.Find<Border>( "bb_");
            //border.PointerPressed += (sender, e) =>
            //{
            //    this.BeginMoveDrag(e)
            //};
            //if(desired_ != double.NaN)
            //{
            //    border.Width = this.desired_;
            //}
        }
      

        //public double DesiredSizeForDragBorderLeft(TemplateAppliedEventArgs e, AuraTabView tabView)
        //{
        //    ItemsPresenter  presenter = tabView.GetControl<ItemsPresenter>(e, "PART_ItemsPresenter");
        //    Button          b         = tabView.GetControl<Button>(e, "PART_AdderButton");
        //    var sum = b.Width + presenter.Width;
        //    return this.Width - sum;   
        //}
    }
}
