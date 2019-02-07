using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        public static void Copy(string sourceFileName, string destFileName)
        {
            string sourceDir = @"C:\Users\User\Documents\KBTU\PP2";
            string backupDir = @"C:\Users\User\Documents";

            try
            {
                string[] txtList = Directory.GetFiles(sourceDir, "MyTest.txt");

                // Copy text files.
                foreach (string f in txtList)
                {
                    // Remove path from the file name.
                    string fName = f.Substring(sourceDir.Length + 1);

                    try
                    {
                        // Will not overwrite if the destination file already exists.
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                    }

                    // Catch exception if the file was already copied.
                    catch (IOException copyError)
                    {
                        Console.WriteLine(copyError.Message);
                    }
                }

                // Delete source files that were copied.
                foreach (string f in txtList)
                {
                    File.Delete(f);
                }

            }

            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }
        }
        public static void Main()
        {
            string path = @"C:\Users\User\Documents\KBTU\PP2\MyTest.txt";
            try
            {
                // Delete the file if it exists.
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // Create the file.
                using (FileStream fs = File.Create(path))
                {

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
    