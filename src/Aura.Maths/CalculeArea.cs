using System;
using System.Collections.Generic;
using System.Text;

namespace Aura.Maths
{
    public class CalculeArea
    {
        /// <summary>
        /// This method calcule the object's area
        /// </summary>
        public double CalculeAreaof2DObject(Poligon Object)
        {
            throw new System.NotImplementedException();
        }

        public double CalculeTriangleArea(Triangle Triangule)
        {
            double a = (Triangule.Base * Triangule.High) / 2; 
            return a;
        }

        public double CalculeSquareArea(Square Square)
        {
            double a = ((int)Square.Side ^ 2);
            return a;
        }

        public double CalculeRectangleArea(Rectangle Rectangle)
        {
            throw new System.NotImplementedException();
        }

        public double CalculeCircleArea(Circle Circle)
        {
            throw new System.NotImplementedException();
        }
    }
}