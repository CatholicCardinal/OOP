using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.Data;
using System.ComponentModel;



namespace Geo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 5, 50, 150, 50);

            graph.DrawLine(pen, 200, 50, 350, 50);
            graph.DrawLine(pen, 200, 250, 350, 250);
            graph.DrawLine(pen, 200, 50, 200, 250);
            graph.DrawLine(pen, 350, 50, 350, 250);

            graph.DrawEllipse(pen, 200, 400, 100, 200);

            graph.DrawLine(pen, 550, 50, 650, 50);
            graph.DrawLine(pen, 550, 50, 500, 100);
            graph.DrawLine(pen, 650, 50, 700, 100);
            graph.DrawLine(pen, 500, 100, 550, 150);
            graph.DrawLine(pen, 700, 100, 650, 150);
            graph.DrawLine(pen, 650, 150, 550, 150);


            graph.DrawLine(pen, 800, 100, 900, 120);
            graph.DrawLine(pen, 900, 120, 1000, 300);
            graph.DrawLine(pen, 1000, 300, 1200, 100);
            graph.DrawLine(pen, 1200, 100, 1000, 150);

            picture.Image = bmp;
        }


    }

}