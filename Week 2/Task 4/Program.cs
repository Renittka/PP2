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
            string resultfile = @"C:\Users\User\Documents\MyTest.txt";

            if (File.Exists(resultfile))
            {
                File.Delete(resultfile);
            }

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
                        //File.Copy(sourceDir, backupDir);
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
            string sourceDir = " ";
            string backupDir = " ";
            string path = @"C:\Users\User\Documents\KBTU\PP2\MyTest.txt";

                // Delete the file if it exists.
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // Create the file.
                using (FileStream fs = File.Create(path))
                {

                }
                Copy(sourceDir, backupDir); // copy the file
        }
    }
}
    