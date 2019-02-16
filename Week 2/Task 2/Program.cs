using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static bool Prime(int x) // function determine if prime or not
        {
            if (x == 1) return false;
            if (x == 2) return true;

            bool res = true;

            for (int i = 2; i < x; ++i)
            {
                if (x % i == 0)
                {
                    res = false;
                    break;
                }
            }
            return res;
        }

        static bool PrimeString(string s) // pass converted element of string into int to IsPrime
        {
            return Prime(int.Parse(s));
        }

        static void Main(string[] args)
        {
            List<string> result = new List<string>();

            using (FileStream fs = new FileStream(@"C:\Users\User\Documents\KBTU\PP2\numb.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string numbsline = sr.ReadLine(); // reading the line
                    string[] nums = numbsline.Split();

                    foreach (var x in nums) // for each element in array nums
                    {
                        if (PrimeString(x)) // function if prime
                        {
                            result.Add(x); // adding result to list res
                        }
                    }      
                }
            }

            //file stream for writing
            using (FileStream fs2 = new FileStream(@"C:\Users\User\Documents\KBTU\PP2\prime.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs2))// class streamwriter for writing to text file
                {
                    foreach (var x in result)
                    {
                        sw.Write(x + " "); // writing result to text file
                    }
                }
            }
        }
    }
}
