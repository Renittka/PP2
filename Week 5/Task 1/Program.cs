using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_1
{
    public class ComplexNumber
    {
        public double a;
        public double b;

        public ComplexNumber()
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine(string.Format("{0} + {1} * i", a, b));
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            M1();
        }

        private static void M1()
        {
            ComplexNumber cn = new ComplexNumber();
            cn.a = int.Parse(Console.ReadLine());
            cn.b = int.Parse(Console.ReadLine());

            Console.WriteLine(cn.ToString());

            FileStream fs = new FileStream("complexnumber.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumber));

            xs.Serialize(fs, cn);
            fs.Close();
        }
 
        private static void M2()
        {
            FileStream fs2 = new FileStream("complexnumber.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs2 = new XmlSerializer(typeof(ComplexNumber));
            ComplexNumber cn = xs2.Deserialize(fs2) as ComplexNumber;
            cn.PrintInfo();
            fs2.Close();
        }
    }
}
