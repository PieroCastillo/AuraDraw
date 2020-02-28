using System;
using System.Collections.Generic;
using System.Text;

namespace Aura.Maths
{
    public class Solid : IColoreable
    {
        /// <summary>
        /// This solid's volume in cm3
        /// </summary>
        public double Volume
        {
            get => default;
            set
            {
            }
        }

        public System.Drawing.Color Color
        {
            get => default;
            set
            {
            }
        }

        public Point Ubication
        {
            get => default;
            set
            {
            }
        }

        public double CalculateVolume()
        {
            throw new System.NotImplementedException();
        }
    }
}