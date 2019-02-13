using System; 
using System.Collections.Generic;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace Task_1 
{
    class Sample // class is used to identify, count the number of primes and output them
    {
        protected int[] arr; 
        protected int n; 
        int count = 0;

        /* Sample constructor with two parameters: array and its length 
         with public access modifier (accessible from anywhere in the code)*/
        public Sample(int[] arr, int n) 
        {
            this.arr = arr; 
            this.n = n; 
        }

        public void PrintCount() // method is used to count the number of primes 
        {
            for (int i = 0; i < n; i++)
            {
                if (Prime(arr[i])) // if prime function returns true value, then count increments
                {
                    count++; 
                }
            }
            Console.WriteLine(count); //output the counted number of primes
        }

        public void PrintS() // method is used to output the array of prime numbers
        {
            for (int i = 0; i < n; i++) 
            {
                if (Prime(arr[i])) // if prime function returns true value, then it outputs the prime number
                {
                    Console.Write(arr[i] + " ");
                }
            } 
        }

        bool Prime(int b) // function to define a prime
        {
            if (b == 1) return false; // if the number equals to 1; returns false - not prime
            for (int i = 2; i <= Math.Sqrt(b); i++)
                if (b % i == 0) // if the number divides by the i, if false - not prime, if true - prime
                    return false;
            return true; 
        }
    }

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

            s.PrintCount(); // call the method for counting the number of primes
            s.PrintS(); // and for output the primes
        }
    }
}
