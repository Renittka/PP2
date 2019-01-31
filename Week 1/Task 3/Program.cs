using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{

    class ArrayOut  // class is used to double the array elements 
    {
        protected int[] Arr;
        protected int n; 

        public ArrayOut(int[] Arr, int n) //ArrayOut constructor with two parameters: array a and array length n with public access modifier (accessible from anywhere in the code)
        {
            this.Arr = Arr; 
            this.n = n; 
        }

        public void PrintInfo() // method is used to print numbers twice
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
            int n = int.Parse(Console.ReadLine()); // method .Parse converts string of a number to integer equivalent
            int[] a = new int[n];
            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' }); // method .Split that splits string to elements
            
            for (int i =0; i < n; i++)
            {
                a[i] = int.Parse(nums[i]);
            }

            ArrayOut b = new ArrayOut(a, n); // creation object with two parameters: array a and length of the array n

            b.PrintInfo(); // call the method for output doubled array
        }
    }
}
