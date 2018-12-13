using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerCSharp
{
    public class Angle
    {
        private double _angle;
        private double factor = Math.PI / 180;

        public double Degrees
        {
            get
            {
                return _angle;
            }
            set
            {
                if (value > 360.0 || value < 0.0) throw new ArgumentException("Invalid angle value");
                _angle = value;
            }
        }
        public double Radians
        {
            get
            {
                return _angle * factor;
            }
            set
            {
                if (value < 0.0 || value > 2 * Math.PI) throw new ArgumentException("Invalid angle value");
                _angle = value / factor;
            }
        }


    }
}
