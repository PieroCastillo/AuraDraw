using System;
using System.Collections.Generic;
using System.Text;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Media;
using Aura.Utilities.Brushes;

namespace Aura.Utilities.Brushes
{
    public static class GradientGenerator
    {
        public static IGradientBrush GenerateBrush(AvaloniaList<GradientStop> Stops, GradientBrush GradientBrush_  ,GradientSpreadMethod gradientSpread = GradientSpreadMethod.Pad)
        {
            GradientBrush_.SpreadMethod = gradientSpread;
            GradientBrush_.GradientStops.Clear();
            GradientBrush_.GradientStops.AddRange(Stops);
            return GradientBrush_;
        }
    }
}
