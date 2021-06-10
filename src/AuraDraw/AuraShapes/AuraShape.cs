using Avalonia;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraDraw.AuraShapes
{
    public abstract class AuraShape
    {
        public Point StartPoint { get; protected set; }
        public Point EndPoint { get; protected set; }

        public virtual void HandleStart(Point point)
        {
            StartPoint = point;
        }

        public virtual void HandleEnd(Point point)
        {
            EndPoint = point;
        }

        public abstract void Render(DrawingContext context);
    }
}
