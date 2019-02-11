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
      
        public FileSystemInfo[] Content
        {
            get;
            set;
        }
        public int SelectedItem
        {
            get;
            set;
        }

        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < Content.Length; ++i)
            {
                if (i == SelectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }
                else Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(i + 1 + ". " + Content[i].Name);
            }
        }
    }
}
