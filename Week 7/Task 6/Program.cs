using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += DoIt;
            timer.Enabled = true;
            timer.Start();
            Thread.CurrentThread.Join();
        }
        private static void DoIt(object sender, ElapsedEventArgs e)
        {
            int x = 0;
            int y = 0;
            while (true)
            {

            }
        }
    }
}

