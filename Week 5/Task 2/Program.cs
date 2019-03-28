using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace Task2
{
    [Serializable]
    public class Mark
    {
        public int Points { get; set; }

        public string Letter;

        public Mark() { }

        public Mark(int a)
        {
            Points = a;
            Letter = GetLetter(a);
        }

        public string GetLetter(int Points)
        {
            if (Points > 94)
            {
                return "A";
            }
            if (Points < 94 && Points > 89)
            {
                return "A-";
            }
            if (Points < 90 && Points > 84)
            {
                return "+B";
            }
            if (Points < 85 && Points > 79)
            {
                return "B";
            }
            else return "F";
        }

        public override string ToString()
        {
            return Points + " = " + Letter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mark mark1 = new Mark(95);
            Mark mark2 = new Mark(90);
            Mark mark3 = new Mark(85);

            List<Mark> marks = new List<Mark>() { mark1, mark2, mark3 };

            FileStream fs = new FileStream("Marks.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(marks.GetType());

            xs.Serialize(fs, marks);
            fs.Close();
            Des(marks);
        }

        static void Des(List<Mark> marks)
        {
            FileStream fs = new FileStream("Marks.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(marks.GetType());
            List<Mark> marksave = xs.Deserialize(fs) as List<Mark>;

            foreach (var s in marksave)
            {
                Console.WriteLine(s.ToString());
            }

            fs.Close();
        }
    }
}