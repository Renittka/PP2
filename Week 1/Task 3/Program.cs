using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{

    class ArrayOut
    {
        //int[] a = new int[n];
        //public void Print()
        //{

        //}
        protected int[] Arr;
        protected int n;

        public ArrayOut(int[] Arr, int n)
        {
            this.Arr = Arr;
            this.n = n;
        }

        public void PrintInfo()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(Arr[i] + " ");
                Console.Write(Arr[i] + " ");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' });
            for (int i =0; i < n; i++)
            {
                a[i] = int.Parse(nums[i]);
            }

            ArrayOut b = new ArrayOut(a, n);

            b.PrintInfo();
        }
    }
}
