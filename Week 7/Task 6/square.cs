using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace Task_6
{
    class square
    {
        List<Point> points = new List<Point>();
        int x;
        int y;
        int index = 119;

        public void Move()
        {
            System.Timers.Timer timer = new System.Timers.Timer(100);
            timer.Elapsed += Moving;
            timer.Enabled = true;
            Thread.CurrentThread.Join();
        }

        private void Moving(object sender, ElapsedEventArgs e)
        {
            x = points[index].X;
            y = points[index].Y;
            index--;
            index %= 120;
            Draw();
        }

        public void Add()
        {
            for (int i = 0; i < 20; ++i)
            {
                points.Add(new Point { X = 0, Y = i });
            }
            for (int i = 0; i < 40; ++i)
            {
                points.Add(new Point { X = i, Y = 19 });
            }
            for (int i = 19; i >= 0; --i)
            {
                points.Add(new Point { X = 39, Y = i });
            }
            for (int i = 39; i >= 0; --i)
            {
                points.Add(new Point { X = i, Y = 0 });
            }
        }
        public void Draw()
        {
            for (int i = 0; i < points.Count; ++i)
            {
                Console.SetCursorPosition(points[i].X, points[i].Y);
                if (x == points[i].X && y == points[i].Y)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write('*');
                }
                else
                {
                    Console.ResetColor();
                    Console.Write('#');
                }
            }
        }
    }
}