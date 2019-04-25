using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Touchball
{
    public partial class Form1 : Form
    {
        int dx = 4, dy = -4;
        int x, y;
        Random random = new Random();

        SolidBrush solidBrush = new SolidBrush(Color.Red);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.HotPink, 0, 0, 1600, 1800);
            e.Graphics.FillPie(solidBrush, new Rectangle(x, y, 200, 200), 0, 360);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            x += dx;
            y += dy;
            if (y>= 400)
            {
                dy = -4;
            }
            if (y <= 0)
            {
                dy = 4;
            }
            if (x <= 0)
            {
                dx = 4;
            }
            if (x >= 500)
            {
                dx = -4;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(Math.Pow(2, e.Location.X - x - 200) + Math.Pow(2, e.Location.Y - y -200) <= 10000)
            {
                solidBrush.Color = Color.Green;

            }


        }
    }
}
