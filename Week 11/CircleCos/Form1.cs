using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleCos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a += 50 * Math.Cos(x);
            x += 0.25;
            b -= 0.25;
            Refresh();

        }
        double a = 250;
        double b = 250;
        double x;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            e.Graphics.FillEllipse(solidBrush, (int)a, (int)b, 50, 50);
        }
    }
}
