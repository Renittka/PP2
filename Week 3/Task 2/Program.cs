using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static bool IsPal(string name)
        {
            bool res = true;

            for (int i =0; i < name.Length/2; i++)
            {
                if(name[i] == name[name.Length - 1 - i])
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
        static bool IsFileWithPalName(FileInfo f)
        {
            return IsPal(Path.GetFileNameWithoutExtension(f.Name));
        }
        static int CountPals(FileInfo[] files)
        {
            int cnt = 0;
            foreach(var f in files)
            {
                if (IsFileWithPalName(f))
                {
                    cnt++;
                }
            }

            return cnt;
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");

            foreach (var y in dir.GetDirectories())
            {
                try
                {
                    var items = dir.GetFiles(".txt");
                    int x = CountPals(items);
                    Console.WriteLine(y.Name + " " + x);

                }
                catch(Exception e)
                {

                }
            }
        }
    }
}
