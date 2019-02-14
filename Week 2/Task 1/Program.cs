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
        {   /* Provides a Stream for a file, supporting both synchronous and asynchronous read and write operations */
            using (FileStream fs = new FileStream(@"C:\Users\User\Documents\KBTU\PP2\palin.txt", FileMode.Open, FileAccess.Read))
            {
                /* Implements a TextReader that reads characters from a byte stream; reading from a file */
                using (StreamReader sr = new StreamReader(fs))
                {
                    int counter = 0;
                    string text = sr.ReadToEnd(); //reading the string

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == text[text.Length - i - 1]) // if elements are symmetric - counter increments
                        {
                            counter++;
                        }
                        else counter = 0;
                    }

                    if (counter == text.Length) // if counter = word's length 
                    {
                        Console.WriteLine("Yes");
                    }
                    else Console.WriteLine("No");
                }

            }
        }
     }
}
 
