using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rounds
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.DarkOrange, 2);
        Pen pen2 = new Pen(Color.Pink, 3);
        int radius = 100, centerx = 200, centery = 150, secrad;
        double secx, secy;
        float secangle = 270;


        public Form1()
        {
            InitializeComponent();
            secrad = radius - 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secangle += 6;
            if (secangle % 180 == 0) secangle = 180;
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            secx = centerx + secrad * Math.Cos(secangle * Math.PI / 180);
            secy = centery + secrad * Math.Sin(secangle * Math.PI / 180);
            g.DrawArc(pen, centerx - radius, centery - radius, 2 * radius, 2 * radius, -360, -180);
            g.DrawLine(pen2, centerx, centery, (float)secx, (float)secy);
        }
    }
}
