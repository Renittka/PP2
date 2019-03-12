using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_2
{
    class Program
    {
        class Mark
        {
            public int point
            {
                get;
                set;
            }

            public string mark = "1";
            public Mark()
            {

            }

            public void GetLetter()
            {
                switch (point)
                {
                    case 1 when point > 94:
                        {
                            mark = "A";
                        }
                        break;
                    case 2 when point > 91 && point < 94:
                        {
                            mark = "A-";
                        }
                        break;
                    case 3 when point > 86 && point < 90:
                        {
                            mark = "B+";
                        }
                        break;

                    case 4 when point > 81 && point < 85:
                        {
                            mark = "B";
                        }
                        break;

                    case 5 when point > 76 && point < 80:
                        {
                            mark = "B-";
                        }
                        break;

                    case 6 when point > 71 && point < 75:
                        {
                            mark = "C+";
                        }
                        break;

                    case 7 when point > 66 && point < 70:
                        {
                            mark = "C";
                        }
                        break;

                    case 8 when point > 61 && point < 65:
                        {
                            mark = "C-";
                        }
                        break;

                    case 9 when point > 56 && point < 60:
                        {
                            mark = "D+";
                        }
                        break;

                    case 10 when point > 51 && point < 50:
                        {
                            mark = "D";
                        }
                        break;

                    case 11 when point > -1 && point < 50:
                        {
                            mark = "F";
                        }
                        break;
                }

            }
            public override string ToString()
            {
                return point + " + " + mark;

            }
        }
        private static void M1()
        {
            FileStream fs = new FileStream("Marks.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));

            List<Mark> markList = new List<Mark>();
            markList.Add(new Mark
            {
                point = int.Parse(Console.ReadLine().ToString()),
                mark = markList.ToString();
            });

            m.point = int.Parse(Console.ReadLine());
            
             m.GetLetter();

            Console.WriteLine(m.ToString());

            xs.Serialize(fs, markList);

            fs.Close();
        }
        private static void M2()
        {
            FileStream fs = new FileStream("Marks.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Mark));

            Mark m = xs.Deserialize(fs) as Mark; 
            fs.Close();

        }
        static void Main(string[] args)
        {
            M1();

        }
    }
}
