using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball
{
    public partial class Form1 : Form
    {
        private int bw = 100;
        private int bh = 100;
        private int bpx = 0;
        private int bpy = 0;
        private int mStepx = 4;
        private int mStepy = 4;

        private int bpx2 = 500;
        private int bpy2 = 0;
        private int mStepx2 = 4;
        private int mStepy2 = 4;


        public Form1()
        {
            InitializeComponent();
           this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bpx += mStepx;
            bpx2 += mStepx2;
            if (bpx < 0 || bpx + bw > this.ClientSize.Width)
            {
                mStepx = -mStepx;
            }

            if (bpx2 < 0 || bpx2 + bw > this.ClientSize.Width)
            {
                mStepx2 = -mStepx2;
            }

            bpy += mStepy;
            bpy2 += mStepy2;

            if (bpy < 0 || bpy + bh > this.ClientSize.Height)
            {
                mStepy = -mStepy;

            }

            if (bpy2 < 0 || bpy2 + bh > this.ClientSize.Height)
            {
                mStepy2 = -mStepy2;

            }

            if (Math.Sqrt(Math.Pow(bpx - bpx2, 2) + Math.Pow(bpy - bpy2, 2)) <= bh)
            {
                mStepy = -mStepy;
                mStepx = -mStepx;
                mStepx2 = -mStepx2;
                mStepy2 = -mStepy2;
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush pen = new SolidBrush(Color.Red);
            SolidBrush pen2 = new SolidBrush(Color.BlueViolet);
            e.Graphics.FillEllipse(pen, bpx, bpy, bw, bh);
            e.Graphics.FillEllipse(pen2, bpx2, bpy2, bw, bh);
        }
    }
}
