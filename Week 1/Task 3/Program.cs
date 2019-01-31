using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{

    class ArrayOut  
    {
        protected int[] Arr; //declaration of the array arr, which will contain values ​​of type int
        protected int n; //declaration of array length n of int type

        public ArrayOut(int[] Arr, int n) //Class "ArrayOut" constructor with two parameters: array a and array length n with public access modifier, class member is accessible from anywhere in the code
        {
            this.Arr = Arr; 
            this.n = n; 
        }

        public void PrintInfo()//
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
