using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Microsoft.Toolkit.Extensions;
using System.Threading.Tasks;
using System;
using Aura.UI.Windows;
using Avalonia.LogicalTree;

namespace AuraDraw.App.Views
{
    public class PropertiesView : UserControl
    {
        Button FillBrush_button_;
        Button BorderBrush_button_;
        TextBox height_control_;
        TextBox width_control_;
        TextBox thickness_control_;
        public PropertiesView()
        {
            this.InitializeComponent();

            FillBrush_button_ = this.Find<Button>("fill_value");
            BorderBrush_button_ = this.Find<Button>("color_border_value");
            height_control_ = this.Find<TextBox>("height_value");
            width_control_ = this.Find<TextBox>("width_value");
            thickness_control_ = this.Find<TextBox>("thickness_value");

            height_control_.TextInput += Height_control__TextInput;
            width_control_.TextInput += Width_control__TextInput;
            FillBrush_button_.Click += FillBrush_button__Click;
        }

        private void FillBrush_button__Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var colorwin_ = new ChangeColorWindow();
            colorwin_.Show();

            colorwin_.SetBrush(this.BackgroundOfSelectedControl);
        }

        private void Width_control__TextInput(object sender, Avalonia.Input.TextInputEventArgs e)
        {
            if(width_control_.Text.IsNumeric() == true)
            {
                this.WidthOfSelectedControl = Int16.Parse(width_control_.Text);
            } 
        }

        private void Height_control__TextInput(object sender, Avalonia.Input.TextInputEventArgs e)
        {
            if(height_control_.Text.IsNumeric() == true)
            {
                this.HeightOfSelectedControl = Int32.Parse(height_control_.Text);
            }
        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public int HeightOfSelectedControl
        {
            get { return GetValue(HeightOfSelectedControlProperty); }
            set { SetValue(HeightOfSelectedControlProperty, value); }
        }
        public static readonly StyledProperty<int> HeightOfSelectedControlProperty =
            AvaloniaProperty.Register<PropertiesView, int>(nameof(HeightOfSelectedControl));

        public int WidthOfSelectedControl
        {
            get { return GetValue(WidthOfSelectedControlProperty); }
            set { SetValue(WidthOfSelectedControlProperty, value); }
        }
        public static readonly StyledProperty<int> WidthOfSelectedControlProperty =
            AvaloniaProperty.Register<PropertiesView, int>(nameof(WidthOfSelectedControl));
        public IBrush BackgroundOfSelectedControl
        {
            get { return GetValue(BackgroundOfSelectedControlProperty); }
            set { SetValue(BackgroundOfSelectedControlProperty, value); }
        }
        public static readonly StyledProperty<IBrush> BackgroundOfSelectedControlProperty =
            AvaloniaProperty.Register<PropertiesView, IBrush>(nameof(BackgroundOfSelectedControl));
        public IBrush ForegroundOfSelectedControl
        {
            get { return GetValue(ForegroundOfSelectedControlProperty); }
            set { SetValue(ForegroundOfSelectedControlProperty, value); }
        }

        public static readonly StyledProperty<IBrush> ForegroundOfSelectedControlProperty =
            AvaloniaProperty.Register<PropertiesView, IBrush>(nameof(ForegroundOfSelectedControl));

        public bool IsReady
        {
            get;
            protected set;
        }
    }
}