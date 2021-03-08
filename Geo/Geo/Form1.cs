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
            picture.MouseMove += picture_MouseMove;
            picture.MouseUp += picture_MouseUp;
            picture.MouseDown += picture_MouseDown;
        }


        public Pen peny= new Pen(Color.Black);
        public Point start=new Point(0,0), finish = new Point(0, 0);
        public bool drawing = new bool();
        public Bitmap bm = new Bitmap(2000, 2000);
        public Bitmap bm2 = new Bitmap(2000, 2000);
        public Graphics g;
        public Image orig;

        Figure figure;
        Point temp = new Point();

        public void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            var finish = new Point(e.X, e.Y);
            bm2 = new Bitmap(bm);
            picture.Image = bm2;
            var pen = new Pen(Color.Black, 1f);
            var g = Graphics.FromImage(bm2);
            figure.width_border(checkBox2.Checked, textBox1.Text, pen);
            figure.color_border(checkBox3.Checked, comboBox2.Text, pen);
            figure.Draw_picture(pen, g, start, finish);
            figure.cheking_fill_color(checkBox1.Checked, comboBox1.Text, pen, g, start, finish);
            g.Dispose();
            picture.Invalidate();
        }

        public void picture_MouseUp(object sender, MouseEventArgs e)
        {
            var finish = new Point(e.X, e.Y);
            var g = Graphics.FromImage(bm);
            var pen = new Pen(Color.Black, 1f);
            figure.width_border(checkBox2.Checked, textBox1.Text, pen);
            figure.color_border(checkBox3.Checked, comboBox2.Text, pen);
            if (figure.drawing == true)
            {
                start = temp;
            }
            figure.Draw_picture(pen, g, start, finish);
            figure.cheking_fill_color(checkBox1.Checked, comboBox1.Text, pen, g, start, finish);
            g.Save();
            drawing = false;
            g.Dispose();
            picture.Invalidate();
            temp = finish;
        }
        public void picture_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            orig = bm;
            drawing = true;
        }
        public void inizialization(Figure figure)
        {
            figure.drawing = drawing;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            figure = new Line();
            inizialization(figure);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            figure = new Circle();
            inizialization(figure);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            figure = new Square();
            inizialization(figure);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            figure = new BrokenLine();
            inizialization(figure);
            figure.drawing = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            figure = new Polygon();
            figure.number(textBox2.Text);
            inizialization(figure);
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

