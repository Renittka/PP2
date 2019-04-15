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
                    new Point(180, 303),
                    new Point(165, 323),
                    new Point(195, 323)
                     };
                Point[] myPointArray1 = {
                    new Point(180, 330),
                    new Point(165, 310),
                    new Point(195, 310)
                     };

                Point[] myPointArray2 = {
                    new Point(300, 250),
                    new Point(315, 280),
                    new Point(285, 280)
                     };
                Point[] myPointArray3 = {
                    new Point(300, 290),
                    new Point(285, 260),
                    new Point(315, 260)
                     };

                Point[] myPointArray4 = {
                    new Point(400, 50),
                    new Point(415, 80),
                    new Point(385, 80)
                     };
                Point[] myPointArray5 = {
                    new Point(400, 90),
                    new Point(385, 60),
                    new Point(415, 60)
                     };

                Point[] myPointArray6 = {
                    new Point(80, 103),
                    new Point(65, 123),
                    new Point(95, 123)
                     };
                Point[] myPointArray7 = {
                    new Point(80, 130),
                    new Point(65, 110),
                    new Point(95, 110)
                     };

                graphics.FillPolygon(penRed.Brush, myPointArray);
                graphics.FillPolygon(penRed.Brush, myPointArray1);

                graphics.FillPolygon(penRed.Brush, myPointArray2);
                graphics.FillPolygon(penRed.Brush, myPointArray3);

                graphics.FillPolygon(penRed.Brush, myPointArray4);
                graphics.FillPolygon(penRed.Brush, myPointArray5);

                graphics.FillPolygon(penRed.Brush, myPointArray6);
                graphics.FillPolygon(penRed.Brush, myPointArray7);

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
