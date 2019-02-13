using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student // class for define name, id and increment the year
    {
        protected string name;
        protected string id;
        protected int year;

        public Student(string name, string id) // class with 2 parameters: name, id
        {
            this.name = name;
            this.id = id;
            year = 2018;
        }

        public void PrintInfo() // access to name, id and year
        {
            Console.WriteLine(name + " " + id + " " + year);
        }

        public void IncYear() // increases year by 1
        {
            year++;
        }
    }

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