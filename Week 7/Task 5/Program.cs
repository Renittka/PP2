using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            System.Timers.Timer timer = new System.Timers.Timer(1);
            timer.Elapsed += (obj, arg) =>
            {
                Console.SetCursorPosition(1, 1);
                DateTime time = DateTime.Now;
                Console.Write(time.Hour + ":" + time.Minute + ":" + time.Second + ":" + time.Millisecond);
            };
            timer.Enabled = true;
            Thread.CurrentThread.Join();
        }
    }
}
