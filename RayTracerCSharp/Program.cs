using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWrapper cw = new ConsoleWrapper();
            cw.DrawVerticalLine(new Line(new Point(5, 5), new Point(5, 10)), '#');
            Console.ReadLine();
        }
    }
}
