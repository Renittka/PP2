using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            Student s = new Student(x, y); // object with 2 parameters: name and id
            
            s.PrintInfo(); // method to access name, id and current year
            s.IncYear(); // increase year by one
            s.PrintInfo(); // method to access name, id and incremented year
            
        }
    }
}