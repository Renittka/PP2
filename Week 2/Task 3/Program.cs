using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Print(FileSystemInfo fileSystemInfo, int k)
        {
            string s = new string(' ', k); // repeat space k times
            Console.WriteLine(s + fileSystemInfo.Name); // tab + name of files and folders

            if (fileSystemInfo.GetType() == typeof(DirectoryInfo)) // if directory
            {
                FileSystemInfo[] a = ((DirectoryInfo)fileSystemInfo).GetFileSystemInfos(); // content in directory -> array

            for (int i = 0; i < a.Length; i++)
                {
                    Print(a[i], k + 3); // 3 tabs + content of the directory 
                }
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Intel"); // directory declaring 
            Print(dir, 0);
        }
    }
}
