using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a=270, b=0, x = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush pen1 = new SolidBrush(Color.Green);
            SolidBrush pen2 = new SolidBrush(Color.Gray);
            e.Graphics.FillPie(pen1, 150, 100, 100, 100, a, b);
            e.Graphics.FillRectangle(pen2, 150, 250, 120, 20);
            e.Graphics.FillRectangle(pen1, 150, 250, x, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b += 6;
            x += 2;

            if (b > 360)
            {
                b = 0;
                x = 0;
            }
            if (b == 360)
            { 
            timer1.Stop();

            }

            Refresh();
        }
    }
}
