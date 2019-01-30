using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_1
{
    class Sample
    {
        protected int[] arr;
        int[] brr;
        protected int n;
        int count = 0;
        public Sample(int[] arr, int n)
        {
            this.arr = arr;
            this.n = n;
        }
        public void PrintCount()
        {
            for (int i =0; i <n; i++)
            {
                if (prime(arr[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public void PrintS()
        {
            for (int i = 0; i < n; i++)
            {
                if (prime(arr[i]))
                {
                    Console.Write(arr[i] + " " );
                }
            }
    
        }
        bool prime(int b)
        {   if (b == 1) return false;
            for (int i = 2; i <= Math.Sqrt(b); i++)
                if (b % i == 0)
                    return false;
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
      
            int[] a = new int[n];
            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' });

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(nums[i]);
            }
            Sample s = new Sample(a, n);
            s.PrintCount();
            s.PrintS();
        }

    }
}
