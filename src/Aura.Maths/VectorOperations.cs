using System;
using System.Collections.Generic;
using System.Text;

namespace Aura.Maths
{
    public class VectorOperations
    {
        public Vector AddVectors(Vector Vector1, Vector Vector2)
        {
            Vector vect = new Vector();
            vect.Point1.X = Vector1.Point1.X + Vector2.Point1.X;
            vect.Point1.Y = Vector1.Point1.Y + Vector2.Point1.Y;
            vect.Point2.X = Vector1.Point2.X + Vector2.Point2.X;
            vect.Point2.Y = Vector1.Point2.Y + Vector2.Point2.Y;

            return vect;
        }

        /// <param name="Vector1">Minuend</param>
        /// <param name="Vector2">Subtracting</param>
        public Vector MinusVectors(Vector Vector1, Vector Vector2)
        {
            Vector vect = new Vector();
            vect.Point1.X = Vector1.Point1.X - Vector2.Point1.X;
            vect.Point1.Y = Vector1.Point1.Y - Vector2.Point1.Y;
            vect.Point2.X = Vector1.Point2.X - Vector2.Point2.X;
            vect.Point2.Y = Vector1.Point2.Y - Vector2.Point2.Y;

            return vect;
        }

        public Vector OpuestVector(Vector Vector)
        {
            double x1 = Vector.Point1.X;
            double x2 = Vector.Point1.Y;
            double y1 = Vector.Point2.X;
            double y2 = Vector.Point2.Y;

            double newx1 = x1 - (x1 * 2);
            double newx2 = x2 - (x2 * 2); 
            double newy1 = y1 - (y1 * 2); 
            double newy2 = y2 - (y2 * 2);

            Point p1 = new Point();
            Point p2 = new Point();
            p1.X = newx1; p1.Y = newx2;
            p2.X = newy1; p2.Y = newy2;

            Vector vect = new Vector();
            vect.Point1 = p1;
            vect.Point2 = p2;
           
            return vect;
        }   

        public double CalculateVectorModule(Vector Vector)
        {
            int u = (int)(Vector.Point1.X - Vector.Point1.Y)^2 + (int)(Vector.Point2.X - Vector.Point2.Y)^2;
            return Math.Sqrt((double)u);
        }
    }
}