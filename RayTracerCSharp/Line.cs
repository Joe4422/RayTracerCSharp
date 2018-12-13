using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerCSharp
{
    public class Line<T>
    {
        public Point<T> FirstPoint { get; private set; }
        public Point<T> SecondPoint { get; private set; }

        public Line(Point<T> firstPoint, Point<T> secondPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }

        public static LineEquation GetEquation(Line<double> line)
        {
            double diffX = line.FirstPoint.X - line.SecondPoint.X;
            double diffY = line.FirstPoint.Y - line.SecondPoint.Y;
            double m = diffY / diffX;
            double c = line.FirstPoint.Y - m * line.FirstPoint.X;
            return new LineEquation(m, c);
        }
    }
}
