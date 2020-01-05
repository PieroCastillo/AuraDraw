using Avalonia.Media;
using Avalonia.Visuals;
using Avalonia;
using Avalonia.Media.Imaging;

namespace Aura.UI.Brushes
{
    public class AcrylicBrush : ImageBrush, IBrush
    {
        public AcrylicBrush()
        {
            
           /* switch(this.Theme){
                case AcrylicBrushTheme.Dark:
                    base.Source = bitmapDark;
                    break;
                case AcrylicBrushTheme.Light:
                    base.Source = bitmapLight;
                    break;
            } */
      

        }

        public double TintOpacity
        {
            get { return GetValue(TintOpacityProperty); }
            set { SetValue(TintOpacityProperty, value); }
        }
        public static readonly StyledProperty<double> TintOpacityProperty =
            AvaloniaProperty.Register<AcrylicBrush, double>(nameof(TintOpacity),1);
        public double NoiseOpacity { 
            get { return GetValue(NoiseOpacityProperty); } 
            set { SetValue(NoiseOpacityProperty, value); } 
        }
        public static readonly StyledProperty<double> NoiseOpacityProperty =
            AvaloniaProperty.Register<AcrylicBrush, double>(nameof(NoiseOpacity),0.3);

        public AcrylicBrushTheme Theme
        {
            get { return GetValue(ThemeProperty); }
            set { SetValue(ThemeProperty, value); }
        }
        public static readonly StyledProperty<AcrylicBrushTheme> ThemeProperty =
            AvaloniaProperty.Register<AcrylicBrush, AcrylicBrushTheme>(nameof(Theme),AcrylicBrushTheme.Dark);

        

    }

    public enum AcrylicBrushTheme
    {
        Dark,
        Light
    }
}
