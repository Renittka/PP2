using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Star // class Star is used to print star triangle
    {
        protected int n;

        public Star(int n) // constructor of class object
        {
            this.n = n;
        }

        public void Print() // output the star triangle using 2D array
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                Star s = new Star(n); // object of the Star class

                s.Print(); // method to print star triangle
            }
        }
    }
}

