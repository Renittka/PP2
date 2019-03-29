using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "AAAA";
            e1.Id = 1;
            e1.Salary = 50000;
            e1.Increase(e1.Salary);
            e1.Increase(e1.Salary);
            Ser(e1);
            Des();
        }
        static void Ser(Employee e1)
        {
            FileStream fs = new FileStream("employee.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, e1);
            fs.Close();
        }
        static void Des()
        {
            FileStream fs = new FileStream("employee.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            Employee e1des = xs.Deserialize(fs) as Employee;
            fs.Close();
            Console.WriteLine(e1des);
        }
    }

}
