using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerCSharp
{
    public class Line
    {
        public Point FirstPoint { get; private set; }
        public Point SecondPoint { get; private set; }

        public Line(Point firstPoint, Point secondPoint)
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
