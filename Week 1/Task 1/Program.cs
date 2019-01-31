using System; 
using System.Collections.Generic;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace Task_1 //Name space Task 1
{
    class Sample //class Sample is used to identyfy, count the number of primes and output them
    {
        protected int[] arr; //declaration of the array arr, which will contain values ​​of type int
        protected int n; //declaration of array length n of int type
        int count = 0; //declaration of a variable of type int is used to count the number of primes; value assigns to 0, zeroing the variable

        public Sample(int[] arr, int n) //Class "Sample" constructor with two parameters: array a and array length n with public access modifier, class member is accessible from anywhere in the code
        {
            this.arr = arr; //description of the constructor, filling in the parameters of the constructor (array)
            this.n = n; //description of the constructor, filling in the parameters of the constructor(array length)
        }
        public void PrintCount() //method is used to count the number of primes 
        {
            for (int i = 0; i < n; i++) //loop of the length n is used to count primes; repeats for all elements of the array
            {
                if (Prime(arr[i])) //if condition, if prime function returns true value, then
                {
                    count++; // value of the variable count increases by 1
                }
            }
            Console.WriteLine(count); //output the counted number of primes
        }
        public void PrintS() //method is used to output the array of prime numbers
        {
            for (int i = 0; i < n; i++) //loop of the length n is used to output prime number, that repeats for all elements of the array
            {
                if (Prime(arr[i])) //if condition, if prime function returns true value, then
                {
                    Console.Write(arr[i] + " "); //output the prime number
                }
            }
            
        }
        bool Prime(int b) //function to define a prime number with a parameter b to which the array element is passed
        {
            if (b == 1) return false; //if the element of the array equals to 1, it returns false, therefore, it is not a prime number
            for (int i = 2; i <= Math.Sqrt(b); i++) // loop is used to determine whether it is prime number or not, according to math theorem it should be done till sqrt b
                if (b % i == 0) //if condition, if the number (element of the array) divides by the i, then
                    return false; //function returns false, therefore, the number is not prime
            return true; //if the number (element of the array) divide by the i, then it returns true 
        }
    }
    class Program //main class of the program
    {
        static void Main(string[] args) //Main funtion, that first of all starts
        {
            int n = int.Parse(Console.ReadLine()); //declaration and reading of the variable n (array length), using the .Parse method for converting (string to int) into any value into a value of a specific type
            int[] a = new int[n]; //declaration of an array of int type
            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' }); //declaration of an array of string type,  also it is readting with method Split, that splits string to elements 

            for (int i = 0; i < n; i++) //loop for the reading of the array
            {
                a[i] = int.Parse(nums[i]); //assigning the value of each element of the array and the value of the nums divided into elements of the array of strings
            }
            Sample s = new Sample(a, n); //creation object with two parameters
            s.PrintCount(); //call the implementation of the method for counting the number of prime numbers
            s.PrintS(); //call the implementation of the method for output the prime numbers
        }

    }
}
