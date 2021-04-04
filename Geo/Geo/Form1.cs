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
            undostack.Push(bm2);
            //figure.undostack.Push();
            add_fill_color();
            add_line_color();
            picture.MouseMove += picture_MouseMove;
            picture.MouseUp += picture_MouseUp;
            picture.MouseDown += picture_MouseDown;
            figure = new Line();
        }

        public Pen pen= new Pen(Color.Black, 2);
        public Pen pen1 = new Pen(Color.White);
        public Point start=new Point(0,0), finish = new Point(0, 0);
        public bool drawing = new bool();
        public Bitmap bm = new Bitmap(1000, 540);
        public Bitmap bm2 = new Bitmap(1000, 540);
        public Graphics g;
        public Image orig;

        Figure figure;
        Stack<Bitmap> undostack = new Stack<Bitmap>(), redostack = new Stack<Bitmap>();
        Point temp = new Point();
        bool redo = false, undo = false;

        public void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            var finish = new Point(e.X, e.Y);
            bm2 = new Bitmap(bm);
            picture.Image = bm2;
            var g = Graphics.FromImage(bm2);
            figure.Draw_picture(pen, g, start, finish);
            figure.temp = pen;
            figure.fill_color(pen1, g, start, finish);
            g.Dispose();
            picture.Invalidate();
        }

        public void picture_MouseUp(object sender, MouseEventArgs e)
        {
            
            var finish = new Point(e.X, e.Y);
            var g = Graphics.FromImage(bm);
            figure.Draw_picture(pen, g, start, finish);
            figure.ending = finish;
            figure.temp = pen;
            figure.fill_color(pen1, g, start, finish);
                var copy = new Bitmap(bm);
                undostack.Push(copy);
                temp = finish;
            g.Save();
            drawing = false;
            g.Dispose();
            picture.Invalidate();
            
        }
        public void picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (undo == true && redo == true && figure.redostack.Count>0)
                figure.ending = figure.redostack.Pop();
            undo = false;
            redo = false;
            if (figure.redostack.Count > 0)
            {
               // temp = figure.redostack.Pop();
                //figure.redostack.Push(temp);
                figure.redostack.Clear();
            }
            redostack.Clear();
            start = new Point(e.X, e.Y);
            figure.starting = start;
                 figure.undostack.Push(figure.ending);
            orig = bm;
            drawing = true;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            figure = new Line();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            figure = new Circle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            figure = new Square();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            figure = new BrokenLine();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            figure = new Polygon();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            figure.width_border(checkBox2.Checked, textBox1.Text, pen);
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            figure.color_border(checkBox3.Checked,comboBox2.Text, pen);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            figure.cheking_fill_color(checkBox1.Checked,comboBox1.Text,pen1,g,start,finish);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            figure.number(textBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            figure = new RandomPolygon();
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (undostack.Count > 0)
            {
                var bmp = new Bitmap(undostack.Pop());
                redostack.Push(bmp);

                if (undostack.Count > 0)
                    bmp = undostack.Pop();
                this.picture.Image = bmp;
                bm = new Bitmap(bmp);
                undostack.Push(bmp);
                figure.undo = true;
            }
            //polygon
            if (figure.undostack.Count > 0)
            {
                figure.ending = figure.undostack.Pop();
                figure.redostack.Push(figure.ending);
            }
            undo = true;
            //-------------fix ending
            if (figure.redostack.Count == 1)
            {
                var point = figure.redostack.Pop();

                if (temp!=point)
                    figure.redostack.Push(temp);
                figure.redostack.Push(point);
            }
            //-------------
            undo = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (redostack.Count > 0)
            {
                var bmp = new Bitmap(redostack.Pop());
                if (undostack.Count==0)
                {
                    undostack.Push(bmp);
                    bmp = new Bitmap(redostack.Pop());
                }

                this.picture.Image = bmp;
                bm = new Bitmap(bmp);
                undostack.Push(bmp);
           
            }
            //polygon
            if (figure.redostack.Count > 0)
            {
                figure.ending = figure.redostack.Pop();
                figure.undostack.Push(figure.ending);
            }
            redo = true;
        }
    }
}



/*if (((redo == true) || (undo == true)) && figure.redostack.Count > 0)
{
    figure.ending = figure.redostack.Pop();
    figure.undostack.Push(figure.ending);
}
if (((redo == false) && (undo == true)) && figure.undostack.Count > 0)
{
    figure.ending = figure.undostack.Pop();
    figure.redostack.Push(figure.ending);
}*/