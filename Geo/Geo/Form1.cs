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

        public Pen peny= new Pen(Color.Black);
        public Point start=new Point(0,0), finish = new Point(0, 0);
        public bool drawing = new bool();
        public Bitmap bm = new Bitmap(2000, 2000);
        public Bitmap bm2 = new Bitmap(2000, 2000);
        public Graphics g;
        public Image orig;

        Line line = new Line();
        Circle circle = new Circle();
        Square square = new Square();
        Polygon polygon = new Polygon();

        private void button1_Click(object sender, EventArgs e)
        {

            clean_master();
            line.checkBox1 = checkBox1;
            line.checkBox2 = checkBox2;
            line.checkBox3 = checkBox3;
            line.textBox1 = textBox1;
            line.comboBox1 = comboBox1;
            line.comboBox2 = comboBox2;

            line.picture = picture;
            line.pen = peny;
            line.g = g;
            line.start = start;
            line.finish = finish;
            line.drawing = drawing;
            line.bm = bm;
            line.bm2 = bm2;
            line.orig = orig;

            picture.MouseMove += line.picture_MouseMove;
            picture.MouseUp += line.picture_MouseUp;
            picture.MouseDown += line.picture_MouseDown;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean_master();
            circle.checkBox1 = checkBox1;
            circle.checkBox2 = checkBox2;
            circle.checkBox3 = checkBox3;
            circle.textBox1 = textBox1;
            circle.comboBox1 = comboBox1;
            circle.comboBox2 = comboBox2;
            
            circle.picture = picture;
            circle.pen = peny;
            circle.g = g;
            circle.start = start;
            circle.finish = finish;
            circle.drawing = drawing;
            circle.bm = bm;
            circle.bm2 = bm2;
            circle.orig = orig;

            picture.MouseMove += circle.picture_MouseMove;
            picture.MouseUp += circle.picture_MouseUp;
            picture.MouseDown += circle.picture_MouseDown;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            clean_master();
            square.checkBox1 = checkBox1;
            square.checkBox2 = checkBox2;
            square.checkBox3 = checkBox3;
            square.textBox1 = textBox1;
            square.comboBox1 = comboBox1;
            square.comboBox2 = comboBox2;

            square.picture = picture;
            square.pen = peny;
            square.g = g;
            square.start = start;
            square.finish = finish;
            square.drawing = drawing;
            square.bm = bm;
            square.bm2 = bm2;
            square.orig = orig;

            picture.MouseMove += square.picture_MouseMove;
            picture.MouseUp += square.picture_MouseUp;
            picture.MouseDown += square.picture_MouseDown;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            clean_master();
            line.checkBox1 = checkBox1;
            line.checkBox2 = checkBox2;
            line.checkBox3 = checkBox3;
            line.textBox1 = textBox1;
            line.comboBox1 = comboBox1;
            line.comboBox2 = comboBox2;

            line.picture = picture;
            line.pen = peny;
            line.g = g;
            line.start = start;
            line.finish = finish;
            line.drawing = drawing;
            line.bm = bm;
            line.bm2 = bm2;
            line.orig = orig;

            picture.MouseMove += line.picture_MouseMove;
            picture.MouseUp += line.picture_MouseUp;
            picture.MouseUp += line.picture_MouseDown;
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

        
        
        private void button5_Click(object sender, EventArgs e)
        {  
            clean_master();
            polygon.checkBox1 = checkBox1;
            polygon.checkBox2 = checkBox2;
            polygon.checkBox3 = checkBox3;
            polygon.textBox1 = textBox1;
            polygon.comboBox1 = comboBox1;
            polygon.comboBox2 = comboBox2;
            polygon.textBox2 = textBox2;

            polygon.picture = picture;
            polygon.pen = peny;
            polygon.g = g;
            polygon.start = start;
            polygon.finish = finish;
            polygon.drawing = drawing;
            polygon.bm = bm;
            polygon.bm2 = bm2;
            polygon.orig = orig;

            picture.MouseMove += polygon.picture_MouseMove;
            picture.MouseUp += polygon.picture_MouseUp;
            picture.MouseDown += polygon.picture_MouseDown;

        }

        public void clean_master()
        {
            picture.MouseMove -= line.picture_MouseMove;
            picture.MouseUp -= line.picture_MouseUp;
            picture.MouseDown -= line.picture_MouseDown;

            picture.MouseMove -= polygon.picture_MouseMove;
            picture.MouseUp -= polygon.picture_MouseUp;
            picture.MouseDown -= polygon.picture_MouseDown;

            picture.MouseMove -= square.picture_MouseMove;
            picture.MouseUp -= square.picture_MouseUp;
            picture.MouseDown -= square.picture_MouseDown;

            picture.MouseMove -= circle.picture_MouseMove;
            picture.MouseUp -= circle.picture_MouseUp;
            picture.MouseDown -= circle.picture_MouseDown;

            picture.MouseUp -= line.picture_MouseDown;

        }
    }


}

