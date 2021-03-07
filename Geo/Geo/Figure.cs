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
	public abstract class Figure
	{
        public CheckBox checkBox1, checkBox2, checkBox3;
        public TextBox textBox1;
        public ComboBox comboBox1, comboBox2;

        public PictureBox picture;
        public Pen pen;
        public Graphics g;
        public Point start, finish;
        public bool drawing = false;
        public Bitmap bm = new Bitmap(2000, 2000);
        public Bitmap bm2 = new Bitmap(2000, 2000);
        public Image orig;


		public void color_border(CheckBox checkBox3, ComboBox comboBox2, Pen pen)
        {
            if (checkBox3.Checked == true)
            {
                if (comboBox2.Text == "Черный")
                {
                    pen.Color = Color.Black;
                }

                if (comboBox2.Text == "Белый")
                {
                    pen.Color = Color.White;
                }

                if (comboBox2.Text == "Зеленый")
                {
                    pen.Color = Color.Green;
                }

                if (comboBox2.Text == "Синий")
                {
                    pen.Color = Color.Blue;
                }

                if (comboBox2.Text == "Красный")
                {
                    pen.Color = Color.Red;
                }

                if (comboBox2.Text == "Жёлтый")
                {
                    pen.Color = Color.Yellow;
                }
            }
        }
		public void width_border(CheckBox checkBox2, TextBox textBox1, Pen pen)
        {
            if (checkBox2.Checked == true)
            {
                pen.Width = int.Parse(textBox1.Text);

            }
        }

        public abstract void fill_color(Pen pen, Graphics g, Point start, Point finish);

        public void cheking_fill_color(CheckBox checkBox1, ComboBox comboBox1,Pen pen, Graphics g, Point start, Point finish)
        {
            if (checkBox1.Checked == true)
            {
                if (comboBox1.Text == "Черный")
                {
                    pen.Color = Color.Black;
                    fill_color(pen, g, start, finish);
                }

                if (comboBox1.Text == "Белый")
                {
                    pen.Color = Color.White;
                    fill_color(pen, g, start, finish);
                }

                if (comboBox1.Text == "Зеленый")
                {
                    pen.Color = Color.Green;
                    fill_color(pen, g, start, finish);
                }

                if (comboBox1.Text == "Синий")
                {
                    pen.Color = Color.Blue;
                    fill_color(pen, g, start, finish);
                }

                if (comboBox1.Text == "Красный")
                {
                    pen.Color = Color.Red;
                    fill_color(pen, g, start, finish);
                }

                if (comboBox1.Text == "Жёлтый")
                {
                    pen.Color = Color.Yellow;
                    fill_color(pen, g, start, finish);
                }
            }
        }

        public abstract void Draw_picture(Pen pen, Graphics g, Point start, Point finish);

        
        public void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            var finish = new Point(e.X, e.Y);
            bm2 = new Bitmap(bm);
            picture.Image = bm2;
            var pen = new Pen(Color.Black, 1f);
            var g = Graphics.FromImage(bm2);
            width_border(checkBox2, textBox1, pen);
            color_border(checkBox3, comboBox2, pen);
            Draw_picture(pen, g, start, finish);
            cheking_fill_color(checkBox1, comboBox1, pen, g, start, finish);
            g.Dispose();
            picture.Invalidate();
        }

        public void picture_MouseUp(object sender, MouseEventArgs e)
        {
            var finish = new Point(e.X, e.Y);
            var g = Graphics.FromImage(bm);
            var pen = new Pen(Color.Black, 1f);
            width_border(checkBox2, textBox1, pen);
            color_border(checkBox3, comboBox2, pen);
            Draw_picture(pen, g, start, finish);
            cheking_fill_color(checkBox1, comboBox1, pen, g, start, finish);
            g.Save();
            drawing = false;
            g.Dispose();
            picture.Invalidate();
        }

        public void picture_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            orig = bm;
            drawing = true;
        }

	}
}