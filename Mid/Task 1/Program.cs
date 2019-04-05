using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_1
{
    enum State
    {
        RED,
        GREEN,
        YELLOW
    };
    class Text
    {
        State state;
        public void Draw()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                switch (state)
                {
                    case State.RED:
                        if (i == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case State.YELLOW:
                        if (i == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        }
                        break;
                    case State.GREEN:
                        if (i == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        break;
                }
            }
            public void Update()
            {
                switch (state)
                {
                    case State.RED:
                        state = State.YELLOW;
                        break;
                    case State.YELLOW:
                        state = State.GREEN;
                        break;
                    case State.GREEN:
                        state = State.RED;
                        break;
                }
            }
        }
    }
        
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread thread1 = new Thread(Print);
            thread1.Start();

        }
        static void Print()
        {
            string text = "Hello World!";
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += (obj, arg) =>
            {
                Text.Draw();
                Text.Update();
            };
            DateTime time = DateTime.Now;
            foreach (var ch in text)
            {
                Console.WriteLine(text);
            }
            Thread.CurrentThread.Join();
        }
    }
}