using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aura.UI.Brushes
{
    public class BlurConstructor 
    {
        public static Bitmap NewAcrylicSource(byte TintOpacity = 125, byte NoiseOpacity = 125, AcrylicBrushTheme Theme = AcrylicBrushTheme.Dark)
        {
            
            return null;
        }

        public static Bitmap ConverseBitmaptoAcrylic( Bitmap Source ,int Radius  , byte TintOpacity = 125, byte NoiseOpacity = 125 )
        {
            switch (Source){
                case null:
                    return null;
                default:
                    break;
            }
            double w = Source.Size.Width;
            double h = Source.Size.Height;

            int[] pix = new int[(int)w * (int)h];

            
            return null;
        }
    }
}
