using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraDraw.AuraShapes
{
    public class AuraLine : AuraShape
    {
        public override void Render(DrawingContext context)
        {
            context.DrawLine(new Pen(Brushes.Black, 10), StartPoint, EndPoint);
        }
    }
}
