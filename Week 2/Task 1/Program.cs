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
            FileStream fs = new FileStream(@"C:\Users\User\Documents\KBTU\PP2\palin.txt", FileMode.Open, FileAccess.Read); // Provides a Stream for a file, supporting both synchronous and asynchronous read and write operations
            StreamReader sr = new StreamReader(fs); // Implements a TextReader that reads characters from a byte stream; reading from a file

            int counter = 0;
            string text = sr.ReadToEnd(); //reading the string

            for (int i=0; i< text.Length; i++)
            {
                if (text[i] == text[text.Length - i - 1])
                {
                    counter++;
                }
                else counter = 0;
            }

            if (counter == text.Length)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");

            sr.Close();
            fs.Close();
        }

     }
}
 
