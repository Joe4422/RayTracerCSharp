using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RayTracerCSharp
{
    class Program
    {
        static ConsoleWrapper cw;
        static int x = 5;
        static int y = 5;
        static void Main(string[] args)
        {
            cw = new ConsoleWrapper();
            cw.DrawVerticalLine(new Line(new Point(5, 5), new Point(5, 10)), '#');
            cw.KeyPressed += Cw_KeyPressed;
            MainLoop();
        }

        static void MainLoop()
        {
            while (true)
            {
                cw.Clear();
                cw.DrawVerticalLine(new Line(new Point(x, y), new Point(x, y + 5)), '#');
                Thread.Sleep(16);
            }
        }

        private static void Cw_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.KeyInfo.Key == ConsoleKey.UpArrow) y--;
            if (e.KeyInfo.Key == ConsoleKey.DownArrow) y++;
            if (e.KeyInfo.Key == ConsoleKey.LeftArrow) x--;
            if (e.KeyInfo.Key == ConsoleKey.RightArrow) x++;
            cw.Clear();
            cw.DrawVerticalLine(new Line(new Point(x, y), new Point(x, y + 5)), '#');

        }
    }
}
