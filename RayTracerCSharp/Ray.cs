using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerCSharp
{
    public class Ray
    {
        public Point Start { get; private set; }
        public Angle Orientation { get; private set; }
        public Point End;

        private LineEquation Equation
        {
            get
            {
                double m = Math.Tan(Orientation.Radians);
                double c = Start.Y - m * Start.X;
                return new LineEquation(m, c);
            }
        }
    }
}
