﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall: GameObject
    {
        public Wall(): base() { }
        public Wall(char sign) : base(sign)
        {
            LoadLevel(1);
        }
        void LoadLevel(int level)
        {
            string name = string.Format("Levels/Level{0}.txt", level);
            using( StreamReader reader = new StreamReader(name))
            {
                int r = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    for (int c = 0; c < line.Length; c++)
                    {
                        if(line[c] == '#')
                        {
                            body.Add(new Point(c, r));
                        }
                    }
                    r++;
                }
            }
        }
    }
}