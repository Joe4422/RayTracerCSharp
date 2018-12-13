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

        public int DX => Math.Abs(FirstPoint.X - SecondPoint.X);
        public int DY => Math.Abs(FirstPoint.Y - SecondPoint.Y);

        public Line(Point firstPoint, Point secondPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }

        public Point SmallerX => FirstPoint.X < SecondPoint.X ? FirstPoint : SecondPoint;
        public Point SmallerY => FirstPoint.Y < SecondPoint.Y ? FirstPoint : SecondPoint;
        public Point LargerX => FirstPoint.X > SecondPoint.X ? FirstPoint : SecondPoint;
        public Point LargerY => FirstPoint.Y > SecondPoint.Y ? FirstPoint : SecondPoint;



    }
}
