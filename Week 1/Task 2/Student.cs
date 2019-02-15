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
        protected int year = 2018;

        public Student(string name, string id) // class with 2 parameters: name, id
        {
            this.name = name;
            this.id = id;
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
}
