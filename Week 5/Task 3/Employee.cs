using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Employee
    {
        public string name
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public int salary
        {
            get;
            set;
        }

        public Employee()
        {

        }
        public Employee(string name, int id, int salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }


        public void IncSal(int salary)
        {
            salary += 50000;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name + " " + id + " " + salary);
        }
    }
}
