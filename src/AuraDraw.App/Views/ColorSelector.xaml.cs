using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;

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
            ColorView = this.Find<Ellipse>("ColorView");
            Red_Slider = this.Find<Slider>("Red_Slider");
            Red_Enter = this.Find<TextBox>("Red_Enter");
            Green_Slider = this.Find<Slider>("Green_Slider");
            Green_Enter = this.Find<TextBox>("Green_Enter");
            Blue_Slider = this.Find<Slider>("Blue_Slider");
            Blue_Enter = this.Find<TextBox>("Blue_Enter");
            Alpha_Slider = this.Find<Slider>("Alpha_Slider");
            Alpha_Enter = this.Find<TextBox>("Alpha_Enter");
            ColorView.Width = this.ColorViewDiameter;
            ColorView.Height = this.ColorViewDiameter;
            Red_Enter.Text = Red_Slider.Value.ToString();
            Green_Enter.Text = Green_Slider.Value.ToString();
            Blue_Enter.Text = Blue_Slider.Value.ToString();
            Alpha_Enter.Text = Alpha_Slider.Value.ToString();
            this.InitializeComponent();
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
    }
}
