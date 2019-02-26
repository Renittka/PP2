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
        public static void Copy(string sourceDir, string destDir)
        {
            sourceDir = @"C:\Users\User\source\repos\Week 2\Task 2\bin\Debug";
            destDir = @"C:\Users\User\source\repos\Week 2\Task 2\bin\Debug\Folder";
            string resultfile = @"C:\Users\User\source\repos\Week 2\Task 2\bin\Debug\Folder\text.txt";
            string name = "text.txt";

            if (File.Exists(resultfile)) // if file exist in destination - delete
            {
                File.Delete(resultfile);
            }
            // Copy text files.
            File.Copy(Path.Combine(sourceDir, name), Path.Combine(destDir, name)); // Combine name of file and path to copy from and to
            File.Delete(Path.Combine(sourceDir, name));
        }

        public static void Main()
        {
            string sourceDir = " ";
            string destDir = " ";
            string path = @"C:\Users\User\source\repos\Week 2\Task 2\bin\Debug\text.txt";

            // Delete the file if it exists.
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path)) // Create the file.
            {

            }
            Copy(sourceDir, destDir); // copy the file
        }
    }
}
    