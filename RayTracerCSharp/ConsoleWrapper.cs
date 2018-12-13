using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerCSharp
{
    public class ConsoleWrapper
    {
        public int Width => Console.BufferWidth;
        public int Height => Console.BufferHeight;

        public ConsoleWrapper()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;
        }

        public void WriteToPoint(Point p, string s)
        {
            Point cursorPos = new Point(Console.CursorLeft, Console.CursorTop);
            Console.SetCursorPosition(p.X, p.Y);
            Console.Write(s);
            Console.SetCursorPosition(cursorPos.X, cursorPos.Y);
        }
        public void DrawVerticalLine(Line l, char c)
        {
            if (l.DX != 0) throw new ArgumentException("Line is not vertical!");
            else
            {
                for (int y = l.SmallerY.Y; y <= l.LargerY.Y; y++)
                {
                    WriteToPoint(new Point(l.FirstPoint.X, y), c.ToString());
                }
            }
        }
    }
}
