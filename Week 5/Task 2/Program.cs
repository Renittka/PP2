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
            public int mark;

            public Mark()
            {

            }

            public void GetLetter()
            {
                switch (mark)
                {
                    case 95-100:
                        {
                            Console.WriteLine("A");
                        }
                        break;
                    case 91-94:
                        {
                            Console.WriteLine("A-");
                        }
                        break;
                    case 86 - 90:
                        {
                            Console.WriteLine("B+");
                        }
                        break;

                    case 81-85:
                        {
                            Console.WriteLine("B");
                        }
                        break;

                    case 76-80:
                        {
                            Console.WriteLine("B-");
                        }
                        break;

                    case 71 - 75:
                        {
                            Console.WriteLine("C+");
                        }
                        break;

                    case 66 - 70:
                        {
                            Console.WriteLine("C");
                        }
                        break;

                    case 61-65:
                        {
                            Console.WriteLine("C-");
                        }
                        break;

                    case 56-60:
                        {
                            Console.WriteLine("D+");
                        }
                        break;

                    case 51-50:
                        {
                            Console.WriteLine("D");
                        }
                        break;

                    case 0-50:
                        {
                            Console.WriteLine("F");
                        }
                        break;


                }



                //if (mark >= 95)
                //{
                //    Console.WriteLine("A");
                //}
                //else if (mark >= 90 && mark < 95)
                //{
                //    Console.WriteLine("-A")
                //}
                //else
            }


        }
        private static void M1()
        {
            Mark m = new Mark();
            List<int> MarkList = new List<int>();

            m.mark = int.Parse(Console.ReadLine());
            m.GetLetter();
            MarkList.Add(m.mark);

            //FileStream fs = new FileStream("Marks.xml", FileMode.Create, FileAccess.Write);
            //XmlSerializer xs = new XmlSerializer(typeof(Mark));

            //xs.Serialize(fs, m);

            //fs.Close();
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
