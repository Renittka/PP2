using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Pen penWhite = new Pen(Color.White);
        Pen penBlack = new Pen(Color.Black);
        Pen penGreen = new Pen(Color.Green);
        Pen penYellow = new Pen(Color.Yellow);
        Pen penRed = new Pen(Color.Red);
        
        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.Clear(Color.DarkBlue);
            penBlack.Width = 5;
            graphics.DrawRectangle(penBlack, 3, 3, 500, 360);
            DrawAsteroids();
            DrawCircles();
            DrawSpaceShip();
            DrawGun();
            DrawBullet();
            pictureBox1.Image = bitmap; 

            void DrawBullet()
            {
                
                Point[] myPointArray = { new Point(250, 100), new Point(255, 110), new Point(265, 115), new Point(255, 120), new Point(250, 130), new Point(245, 120), new Point(235, 115), new Point(245, 110) };
                graphics.FillPolygon(penGreen.Brush, myPointArray);
            }

            void DrawAsteroids()
            {
                Point[] myPointArray = {
                    new Point(300, 450),
                    new Point(305, 460),
                    new Point(315, 460),
                    new Point(290, 470),
                    new Point(315, 480),
                    new Point(285, 480),
                    new Point(300, 500),
                    new Point(295, 400),
                    new Point(285, 480),
                    new Point(280, 470),
                    new Point(285, 460),
                    new Point(295, 460) };
                graphics.FillPolygon(penRed.Brush, myPointArray);
            }
            void DrawSpaceShip()
            {
                Point[] myPointArray = { new Point(250, 160), new Point(290, 180), new Point(290, 210), new Point(250, 230), new Point(210, 210), new Point(210, 180) };
                graphics.FillPolygon(penYellow.Brush, myPointArray);
            }
            void DrawGun()
            {
                penGreen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                penGreen.EndCap = System.Drawing.Drawing2D.LineCap.Custom;
                penGreen.Width = 15;
                graphics.DrawLine(penGreen, 250, 170, 250, 210);
            }


            void DrawCircles()
            {
                graphics.FillEllipse(penWhite.Brush, 15, 50, 25, 25);
                graphics.FillEllipse(penWhite.Brush, 20, 300, 25, 25);
                graphics.FillEllipse(penWhite.Brush, 200, 35, 25, 25);
                graphics.FillEllipse(penWhite.Brush, 300, 70, 25, 25);
                graphics.FillEllipse(penWhite.Brush, 450, 300, 25, 25);
                graphics.FillEllipse(penWhite.Brush, 400, 200, 25, 25);
                graphics.FillEllipse(penWhite.Brush, 200, 250, 25, 25);
                graphics.FillEllipse(penWhite.Brush, 430, 100, 25, 25);
            }
        }
    }
}
