using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllipseColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen pen = new Pen(Color.Green);
        int d = 0;
        Color[] colors = new Color[] { Color.Green, Color.Red, Color.Yellow, Color.Blue };
        int index = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            d += 5;
           
            //index = (index + 1) % colors.Length;
            //pen.Color = colors[index];
            
            pen.Color = Color.FromArgb(new Random().Next());
            toolStripStatusLabel1.Text = string.Format("[d = {0}]", d);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(pen.Brush, 200 - d, 150 - d, 40 + 2 * d, 40 + 2 * d);
        }
    }
}
