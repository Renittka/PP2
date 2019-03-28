using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Thread 1");
            MyThread t2 = new MyThread("Thread 2");
            MyThread t3 = new MyThread("Thread 3");

            t1.StartThread();
            t2.StartThread();
            t3.StartThread();
            Console.Read();
        }
    }

    class MyThread
    {
        Thread threadfield;

        public MyThread(string name)
        {
            threadfield = new Thread(Func)
            {
                Name = name
            };
        }

        public void StartThread()
        {
            threadfield.Start();
        }

        void Func()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i);
                Thread.Sleep(300);
            }

            Console.WriteLine(Thread.CurrentThread.Name + " завершился ");
        }
    }
}

