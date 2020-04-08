using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System;

namespace AuraDraw.App.Views
{
    public class ColorSelector : UserControl
    {
        private Ellipse ColorView;
        private Slider Red_Slider;
        private TextBox Red_Enter;
        private Slider Green_Slider;
        private TextBox Green_Enter;
        private Slider Blue_Slider;
        private TextBox Blue_Enter; 
        private Slider Alpha_Slider; 
        private TextBox Alpha_Enter;
        public ColorSelector()
        {
            this.InitializeComponent();
            this_Loaded();
            this.SliderChangedValue(new object(), new EventArgs());
        }

        void this_Loaded()
        {
            ColorView = this.Find<Ellipse>("ColorView");
            Red_Slider = this.Find<Slider>("Red_Slider");
            Red_Slider.Value = 255;
            Red_Enter = this.Find<TextBox>("Red_Enter");
            Green_Slider = this.Find<Slider>("Green_Slider");
            Red_Slider.Value = 255;
            Green_Enter = this.Find<TextBox>("Green_Enter");
            Blue_Slider = this.Find<Slider>("Blue_Slider");
            Red_Slider.Value = 255;
            Blue_Enter = this.Find<TextBox>("Blue_Enter");
            Alpha_Slider = this.Find<Slider>("Alpha_Slider");
            Red_Slider.Value = 255;
            Alpha_Enter = this.Find<TextBox>("Alpha_Enter");
            ColorView.Width = this.ColorViewDiameter;
            ColorView.Height = this.ColorViewDiameter;
            Alpha_Slider.PropertyChanged += SliderChangedValue;
            Red_Slider.PropertyChanged += SliderChangedValue;
            Green_Slider.PropertyChanged += SliderChangedValue;
            Alpha_Slider.PropertyChanged += SliderChangedValue;
        }
        #region Properties
        public int ColorViewDiameter
        {
            get { return GetValue(ColorViewDiameterProperty); }
            set { SetValue(ColorViewDiameterProperty, value); }
        }
        private readonly StyledProperty<int> ColorViewDiameterProperty =
            AvaloniaProperty.Register<ColorSelector, int>(nameof(ColorViewDiameter),200);
        #endregion

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        #region EventsAccions
        public void SliderChangedValue(object sender , EventArgs e)
        {
            Red_Enter.Text = Red_Slider.Value.ToString();
            Green_Enter.Text = Green_Slider.Value.ToString();
            Blue_Enter.Text = Blue_Slider.Value.ToString();
            Alpha_Enter.Text = Alpha_Slider.Value.ToString();
            var a = (byte)Alpha_Slider.Value;
            var r = (byte)Red_Slider.Value;
            var g = (byte)Green_Slider.Value;
            var b = (byte)Blue_Slider.Value;
            ColorView.Fill = new SolidColorBrush(new Avalonia.Media.Color(a, r, g, b));
        }
        #endregion
    }
}
