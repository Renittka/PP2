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

            int counter = 0;
            string text = sr.ReadToEnd();
            string[] lines = text.Split();

            for (int i=0; i< lines.Length; i++)
            {
                if (lines[i] == lines[lines.Length - i - 1])
                {
                    counter++;
                }
                else counter = 0;
            }

            if (counter == lines.Length)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");

            sr.Close();
            fs.Close();
        }

     }
}
 
