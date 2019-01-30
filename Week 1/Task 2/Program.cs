using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        protected string name;
        protected string id;
        protected int year;

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
            this.year = 2018;

        }

        public void PrintInfo()
        {
            Console.WriteLine(name + " " + id + " " + year);
        }

        public void IncYear()
        {
            //Console.WriteLine(name + " " + id + " " + year);
            year++;
            Console.WriteLine("Год увеличен!!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            Student s = new Student(x, y);
            s.PrintInfo();
            s.IncYear();
            s.PrintInfo();
        }
    }
}