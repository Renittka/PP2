﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {

        static bool IsPrime(int x) // function determine if prime or not
        {
            if (x == 1) return false;
            if (x == 2) return true;

            bool functionResult = true;

            for (int i = 2; i < x; ++i)
            {
                if (x % i == 0)
                {
                    functionResult = false;
                    break;
                }
            }
            return functionResult;
        }

        static bool IsPrimeString(string s) // pass converted element of string into int to IsPrime
        {
            return IsPrime(int.Parse(s));
        }

        static void Main(string[] args)
        {
            List<string> res = new List<string>();

            FileStream fs = new FileStream(@"C:\Users\User\Documents\KBTU\PP2\numb.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine(); // reading the line
            string[] nums = line.Split(' ');

            foreach (var x in nums) // for each element in array nums
            {
                if (IsPrimeString(x)) // function if prime
                {
                    res.Add(x); // adding result to list res
                }
            }

            sr.Close();
            fs.Close();

            FileStream fs2 = new FileStream(@"C:\Users\User\Documents\KBTU\PP2\prime.txt", FileMode.Create, FileAccess.Write); //file stream for writing
            StreamWriter sw = new StreamWriter(fs2); // class streamwriter for writing to text file

            foreach (var x in res) 
            {
                sw.Write(x + " "); // writing result to text file
                Console.Write(x + " "); // writing result to console
            }

            sw.Close();
            fs2.Close();
        }
    }
}
