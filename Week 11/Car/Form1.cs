using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        int x = 200;
        int x1 = 250;
        int x2 = 225;
        int x3 = 325;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush solidBrush = new SolidBrush(Color.HotPink);
            SolidBrush solidBrush2 = new SolidBrush(Color.Black);

            e.Graphics.FillRectangle(solidBrush, x, 200, 200, 50);
            e.Graphics.FillRectangle(solidBrush2, x1, 170, 100, 30);
            e.Graphics.FillEllipse(solidBrush2, x2, 225, 50, 50);
            e.Graphics.FillEllipse(solidBrush2, x3, 225, 50, 50);
        }

        int stepx = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += stepx;
            x1 += stepx;
            x2+= stepx;
            x3 += stepx;

            if (x < 0 || x  + 200 == this.ClientSize.Width)
            {
                stepx = -stepx;
            }

            Refresh();
        }
    }
}
