using System;
using System.Collections.Generic;
using System.Text;

namespace Aura.Maths.Converters
{
    public class UnitsConverter
    {
        public static int PixelsToInches(int Pixels)
        {
            return (int)(Pixels * 0.01041653543307);
        }

        public static int PixelsToCentemeters(int Pixels)
        {
            return (int)((double)Pixels * 0.026458);
        }

        public static int CentimetersToInches(int Centimeters)
        {
            return (int)(Centimeters * 0.3937007874016);
        }

        public static int CentimetersToPixels(int Centimeters)
        {
            return (int)(Centimeters * 37.7957517575);
        }
        public static int InchesToPixels(int Inches)
        {
            return (int)(Inches * 96.00120946406);
        }

        public static int InchesToCentimeters(int Inches)
        {
            return (int)(Inches * 2.54);
        }
    }
}
