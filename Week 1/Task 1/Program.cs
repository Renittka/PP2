using System; 
using System.Collections.Generic;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace Task_1 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine()); // method .Parse converts string of a number to integer equivalent
            int[] a = new int[n]; 
            string[] nums = Console.ReadLine().Split(); // method .Split that splits string to elements 

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(nums[i]); // assigning array element and divided elements of strings array
            }

            Sample s = new Sample(a, n); // object with two parameters: array and its length

            s.PrintCount(); // method count the number of primes
            s.PrintS(); // and output the primes
        }
    }
}
