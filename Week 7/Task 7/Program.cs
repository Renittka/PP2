using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(PrintTime);
            thread1.Start();

            Thread thread2 = new Thread(Substring);
            thread2.Start();
        }
        static void PrintTime()
        {
            Thread.CurrentThread.Name = "Thread1";
            System.Timers.Timer timer = new System.Timers.Timer(1);
            DateTime time = DateTime.Now;
            Console.WriteLine(time.Hour + ":" + time.Minute + ":" + time.Second);
            Thread.Sleep(3000);
            Console.WriteLine(Thread.CurrentThread.Name + " завершился ");
            //timer.Enabled = true;
            Thread.CurrentThread.Join();
        }

        static void Substring()
        {
            Thread.CurrentThread.Name = "Thread2";
            var input = "asdsdfdfa";
            var stringList = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    var substring = input.Substring(i, j - i + 1);
                    stringList.Add(substring);
                }
            }

            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }
            Thread.Sleep(5000);
            Console.WriteLine(Thread.CurrentThread.Name + " завершился");

        }
    }
}
