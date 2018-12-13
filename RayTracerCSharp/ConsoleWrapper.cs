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

        public void WriteToPoint(Point<int> p, string s)
        {
            Point<int> cursorPos = new Point<int>(Console.CursorLeft, Console.CursorTop);
            Console.SetCursorPosition(p.X, p.Y);
            Console.Write(s);
            Console.SetCursorPosition(cursorPos.X, cursorPos.Y);
        }
        public void DrawLine(Line<int> l)
        {

        }
    }
}
