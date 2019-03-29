using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Anna", 123, 1000);
            FileStream fs = new FileStream("Employee.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            
            xs.Serialize(fs, employee);
            fs.Close();
            Des();

        }
        static void Des()
        {
            FileStream fs = new FileStream("Employee.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            Employee employee = xs.Deserialize(fs) as Employee;
            
            employee.PrintInfo();
            fs.Close();
        }
    }
}
