using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
   public class Point
    {
        int x;
        int y;

        int Filter(int v)
        {
            if (v >= 40)
            {
                v = 0;
            }
            else if (v < 0)
            {
                v = 39;
            }
            return v;
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = Filter(value);
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = Filter(value);
            }
        }
        public Point()
        {

        }
        public Point (int x, int y)
        {
            this.x = x;
            this.y = y; 
        }

    }
}
