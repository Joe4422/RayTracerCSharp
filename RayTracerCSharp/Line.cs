using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerCSharp
{
    public class Line
    {
        public Point<double> FirstPoint { get; private set; }
        public Point<double> SecondPoint { get; private set; }

        public Line(Point<double> firstPoint, Point<double> secondPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }

        public LineEquation GetEquation()
        {
            double diffX = FirstPoint.X - SecondPoint.X;
            double diffY = FirstPoint.Y - SecondPoint.Y;
            double m = diffY / diffX;
            double c = FirstPoint.Y - m * FirstPoint.X;
            return new LineEquation(m, c);
        }
    }
}
