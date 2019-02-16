using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Layer
    {
        public FileSystemInfo[] Content // attributes for the current file or directory
        {
            get;
            set;
        }
        public int SelectedItem // // attributes for the index
        {
            get;
            set;
        }

        public void Draw() // method for drawing the interface
        {
            Console.BackgroundColor = ConsoleColor.Black; // interface of console
            Console.Clear();

            for (int i = 0; i < Content.Length; i++)
            {
                if (i == SelectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta; // background of selected item
                }
                else Console.BackgroundColor = ConsoleColor.Black; // background of nonselected item

                if (Content[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White; // if dir - white color
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow; // file - yellow color
                }

                Console.WriteLine(i + 1 + ". " + Content[i].Name); // index + name of dir or file
            }
        }
    }
}
