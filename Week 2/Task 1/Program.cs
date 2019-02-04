using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    { 

            static void Main(string[] args)
            {
                F2();
            }

            private static void F2()
            {
                FileStream fs = new FileStream(@"C:\Users\User\Documents\KBTU\PP2\palin.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string text = sr.ReadToEnd();
                string[] lines = text.Split('\n');

                Console.WriteLine(lines[2]);

                sr.Close();
                fs.Close();
            }

            private static void F1()
            {
                FileStream fs = new FileStream(@"C:\Users\User\Documents\KBTU\PP2\palin.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string line = "";
                int cnt = 0;
                while (!sr.EndOfStream && cnt <= 2)
                {
                    line = sr.ReadLine();
                    cnt++;
                }

                Console.WriteLine(line);

                sr.Close();
                fs.Close();
            }
     }
}
 
