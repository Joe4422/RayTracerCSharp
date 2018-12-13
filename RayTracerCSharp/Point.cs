using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerCSharp
{
    public class Point<T>
    {
        public T X { get; private set; }
        public T Y { get; private set; }

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}
