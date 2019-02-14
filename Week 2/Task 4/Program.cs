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
            string name = "MyTest.txt";

            if (File.Exists(resultfile)) // if file exist in destination - delete
            {
                File.Delete(resultfile);
            }
                // Copy text files.
                File.Copy(Path.Combine(sourceDir, name), Path.Combine(backupDir, name)); // Combine name of file and path to copy from and to
                File.Delete(sourceDir);
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

                using (FileStream fs = File.Create(path)) // Create the file.
                {

                }
                Copy(sourceDir, backupDir); // copy the file
        }
    }
}
    