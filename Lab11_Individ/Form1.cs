using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab11_Individ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Point[] points = new Point[50];
        Pen pen = new Pen(Color.Black, 2);
        PointF[] polygon = new PointF[7];

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush Brush = new SolidBrush(Color.Blue);
            Graphics g = e.Graphics;
            pen.Color = Color.Red;

            pen.DashStyle = DashStyle.Dash;
            g.DrawLine(pen, 250, 100, 100, 100);
            g.FillRectangle(Brush, 60, 60, 100, 100);

            Brush.Color = Color.Violet;
            g.FillEllipse(Brush, 80, 80, 50, 50);

            Brush.Color = Color.Green;
            g.FillPolygon(Brush, polygon);

            pen.DashStyle = DashStyle.DashDot;
            pen.Color = Color.Orange;
            g.DrawArc(pen, 20, 10, 200, 200, 25, 25);

            pen.DashStyle = DashStyle.Solid;
            pen.Color = Color.Coral;
            g.DrawEllipse(pen, 45, 45, 120, 120);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random r = new Random();
            for (int i = 0; i < 7; i++)
            {
                polygon[i] = new PointF(r.Next(0, 100), r.Next(0, 100));
            }
        }

    }
}
