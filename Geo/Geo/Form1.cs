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
            add_fill_color();
            add_line_color();

        }


        private Point start;
        private bool drawing = false;
        Bitmap bm = new Bitmap(2000, 2000);
        Bitmap bm2 = new Bitmap(2000, 2000);
        private Image orig;

        private void button1_Click(object sender, EventArgs e)
        {
            Clean_event();
            picture.MouseMove += picture_line_MouseMove;
            picture.MouseUp += picture_line_MouseUp;
            picture.MouseDown += picture_line_MouseDown;
        }

        public void picture_line_MouseUp(object sender, MouseEventArgs e)
        {
            var finish = new Point(e.X, e.Y);
            var g = Graphics.FromImage(bm);
            var pen = new Pen(Color.Black, 1f);
            if (checkBox2.Checked == true)
            {
                pen.Width = int.Parse(textBox1.Text);

            }
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
            g.DrawLine(pen, start, finish);
            g.Save();
            drawing = false;
            g.Dispose();
            picture.Invalidate();
        }

        public void picture_line_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            orig = bm;
            drawing = true;
        }

        public void picture_line_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            var finish = new Point(e.X, e.Y);
            bm2 = new Bitmap(bm);
            picture.Image = bm2;
            var pen = new Pen(Color.Black, 1f);
            var g = Graphics.FromImage(bm2);
            if(checkBox2.Checked == true)
            {
                pen.Width = int.Parse(textBox1.Text);

            }
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
            g.DrawLine(pen, start, finish);
            g.Dispose();
            picture.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clean_event();
            picture.MouseMove += picture_circle_MouseMove;
            picture.MouseUp += picture_circle_MouseUp;
            picture.MouseDown += picture_circle_MouseDown;
        }

        public void picture_circle_MouseUp(object sender, MouseEventArgs e)
        {
            var finish = new Point(e.X, e.Y);
            var g = Graphics.FromImage(bm);
            var pen = new Pen(Color.Black, 1f);
            if (checkBox2.Checked == true)
            {
                pen.Width = int.Parse(textBox1.Text);

            }
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
            g.DrawEllipse(pen, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
            if (checkBox1.Checked == true)
            {
                if (comboBox1.Text == "Черный")
                {
                    pen.Color = Color.Black;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Белый")
                {
                    pen.Color = Color.White;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Зеленый")
                {
                    pen.Color = Color.Green;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Синий")
                {
                    pen.Color = Color.Blue;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Красный")
                {
                    pen.Color = Color.Red;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Жёлтый")
                {
                    pen.Color = Color.Yellow;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }
            }
            g.Save();
            drawing = false;
            g.Dispose();
            picture.Invalidate();
        }

        public void picture_circle_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            orig = bm;
            drawing = true;
        }

        public void picture_circle_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            var finish = new Point(e.X, e.Y);
            bm2 = new Bitmap(bm);
            picture.Image = bm2;
            var pen = new Pen(Color.Black, 1f);
            var g = Graphics.FromImage(bm2);
            if (checkBox2.Checked == true)
            {
                pen.Width = int.Parse(textBox1.Text);

            }
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
            g.DrawEllipse(pen, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
            if (checkBox1.Checked == true)
            {
                if (comboBox1.Text == "Черный")
                {
                    pen.Color = Color.Black;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Белый")
                {
                    pen.Color = Color.White;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Зеленый")
                {
                    pen.Color = Color.Green;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Синий")
                {
                    pen.Color = Color.Blue;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Красный")
                {
                    pen.Color = Color.Red;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Жёлтый")
                {
                    pen.Color = Color.Yellow;
                    g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }
            }
                g.Dispose();
            picture.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clean_event();
            picture.MouseMove += picture_square_MouseMove;
            picture.MouseUp += picture_square_MouseUp;
            picture.MouseDown += picture_square_MouseDown;
        }

        public void picture_square_MouseUp(object sender, MouseEventArgs e)
        {
            var finish = new Point(e.X, e.Y);
            var g = Graphics.FromImage(bm);
            var pen = new Pen(Color.Black, 1f);
            if (checkBox2.Checked == true)
            {
                pen.Width = int.Parse(textBox1.Text);

            }
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
            g.DrawRectangle(pen, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
            if (checkBox1.Checked == true)
            {
                if (comboBox1.Text == "Черный")
                {
                    pen.Color = Color.Black;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Белый")
                {
                    pen.Color = Color.White;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Зеленый")
                {
                    pen.Color = Color.Green;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Синий")
                {
                    pen.Color = Color.Blue;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Красный")
                {
                    pen.Color = Color.Red;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Жёлтый")
                {
                    pen.Color = Color.Yellow;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }
            }
            g.Save();
            drawing = false;
            g.Dispose();
            picture.Invalidate();
        }

        public void picture_square_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            orig = bm;
            drawing = true;
        }

        public void picture_square_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            var finish = new Point(e.X, e.Y);
            bm2 = new Bitmap(bm);
            picture.Image = bm2;
            var pen = new Pen(Color.Black, 1f);
            var g = Graphics.FromImage(bm2);
            if (checkBox2.Checked == true)
            {
                pen.Width = int.Parse(textBox1.Text);

            }
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
            g.DrawRectangle(pen, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
            if (checkBox1.Checked == true)
            {
                if (comboBox1.Text == "Черный")
                {
                    pen.Color = Color.Black;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Белый")
                {
                    pen.Color = Color.White;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Зеленый")
                {
                    pen.Color = Color.Green;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Синий")
                {
                    pen.Color = Color.Blue;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Красный")
                {
                    pen.Color = Color.Red;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }

                if (comboBox1.Text == "Жёлтый")
                {
                    pen.Color = Color.Yellow;
                    g.FillRectangle(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
                }
            }
            g.Dispose();
            picture.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clean_event();
            picture.MouseMove += picture_pen_MouseMove;
            picture.MouseDown += picture_pen_MouseDown;
        }

        public void picture_pen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var finish = new Point(e.X, e.Y);
                var pen = new Pen(Color.Black, 1f);
                var g = Graphics.FromImage(bm2);
                g.DrawRectangle(pen, e.X, e.Y, 1, 1);
                picture.Image = bm2;
            }
        }

        public void picture_pen_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
        }

        private void Clean_event()
        {
            picture.MouseMove -= picture_circle_MouseMove;
            picture.MouseUp -= picture_circle_MouseUp;
            picture.MouseDown -= picture_circle_MouseDown;

            picture.MouseMove -= picture_line_MouseMove;
            picture.MouseUp -= picture_line_MouseUp;
            picture.MouseDown -= picture_line_MouseDown;

            picture.MouseMove -= picture_square_MouseMove;
            picture.MouseUp -= picture_square_MouseUp;
            picture.MouseDown -= picture_square_MouseDown;

            picture.MouseMove -= picture_pen_MouseMove;
            picture.MouseDown -= picture_pen_MouseDown;
        }

        private void add_fill_color()
        {
            comboBox1.Items.Add("Белый");
            comboBox1.Items.Add("Черный");
            comboBox1.Items.Add("Зеленый");
            comboBox1.Items.Add("Синий");
            comboBox1.Items.Add("Красный");
            comboBox1.Items.Add("Жёлтый");
        }

        private void add_line_color()
        {
            comboBox2.Items.Add("Белый");
            comboBox2.Items.Add("Черный");
            comboBox2.Items.Add("Зеленый");
            comboBox2.Items.Add("Синий");
            comboBox2.Items.Add("Красный");
            comboBox2.Items.Add("Жёлтый");
        }

    }

}

