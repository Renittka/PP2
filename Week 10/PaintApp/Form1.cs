using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    enum Tools
    {
        Pencil,
        Rectangle,
        Ellipse,
        Line,
        Fill
    }

    public partial class Form1 : Form
    {
        Tools CurrTool = Tools.Pencil;
        Pen pen = new Pen(Color.Red);
        Graphics graphics;
        Bitmap bitmap;
        Point firstPoint;
        Point secondPoint;


        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrTool = Tools.Pencil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrTool = Tools.Rectangle;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrTool = Tools.Ellipse;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CurrTool = Tools.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CurrTool = Tools.Line;
        }
        Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle
            {
                X = Math.Min(p1.X, p2.X),
                Y = Math.Min(p1.Y, p2.Y),
                Width = Math.Abs(p1.X - p2.X),
                Height = Math.Abs(p2.Y - p2.Y)
            }; 
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
