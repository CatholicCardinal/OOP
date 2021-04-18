using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



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
            figure = new Line();
        }

        public Pen pen = new Pen(Color.Black, 2);
        public Pen pen1 = new Pen(Color.White);
        public Point start = new Point(0, 0), finish = new Point(0, 0);
        public bool drawing = new bool();
        public Bitmap bm = new Bitmap(1000, 540);
        public Bitmap bm2 = new Bitmap(1000, 540);
        public Graphics g;
        public Image orig;

        Figure figure;
        UndoRedo history = new UndoRedo();

        public void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            var finish = new Point(e.X, e.Y);
            bm2 = new Bitmap(bm);
            picture.Image = bm2;
            var g = Graphics.FromImage(bm2);
            if (history.RP == true)
                figure.truepolygon = history.castil();
            figure.Draw_picture(pen, g, start, finish);
            figure.temp = pen;
            figure.fill_color(pen1, g, start, finish);
            g.Dispose();
            picture.Invalidate();
        }

        public void picture_MouseUp(object sender, MouseEventArgs e)
        {
            var finish = new Point(e.X, e.Y);
            g = Graphics.FromImage(bm);
            if (history.RP == true)
                history.addRP(true);
            else history.addRP(false);
            if (history.RP == true)
                figure.truepolygon = history.castil();
            figure.Draw_picture(pen, g, start, finish);
            history.addbordercolor(pen.Color);
            figure.ending = finish;
            figure.temp = pen;
            figure.help = pen.Color;
            figure.fill_color(pen1, g, start, finish);
            history.addpen(pen);
            history.addwidth((int)pen.Width);
            history.addundo(figure);
            history.addfinish(finish);
            if (history.BL == true)
                history.addBL(true);
            else history.addBL(false);
            if (history.RP == true)
                figure.truepolygon = history.castil();
            g.Save();
            drawing = false;
            g.Dispose();
            picture.Invalidate();
        }
        public void picture_MouseDown(object sender, MouseEventArgs e)
        {
            history.addpen1(pen1.Color);
            start = new Point(e.X, e.Y);
            history.cleanall();
            history.addstart(start);
            if (history.RP == true)
                figure.truepolygon = history.castil();
            figure.starting = start;
            orig = bm;
            drawing = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figure = new Line();
            history.BL = false;
            history.RP = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            figure = new Circle();
            history.BL = false;
            history.RP = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            figure = new Square();
            history.BL = false;
            history.RP = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            figure = new BrokenLine();
            history.BL = true;
            history.RP = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            figure = new Polygon();
            history.RP = false;
            history.BL = false;
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
            figure.color_border(checkBox3.Checked, comboBox2.Text, pen);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            figure.cheking_fill_color(checkBox1.Checked, comboBox1.Text, pen1, g, start, finish);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            figure.number(textBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            figure = new RandomPolygon();
            history.RP = true;
            history.BL = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            figure.PR = true;
            picture.Image = history.refresh(picture.Image);

            history.redo();

            var up = new Bitmap(1000, 540);
            picture.Image = up;
            g = Graphics.FromImage(up);
            history.imageupdate(g);
            if (history.RP == true)
                figure.truepolygon = history.castil();
            else figure.truepolygon = null;
            bm = up;
            figure.PR = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            figure.PR = true;
            picture.Image = history.refresh(picture.Image);
            history.undo();
            if (history.RP == true)
                figure.truepolygon = history.castil();
            var up = new Bitmap(1000, 540);
            picture.Image = up;
            g = Graphics.FromImage(up);
            history.imageupdate(g);
            bm = up;
            figure.PR = false;
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

     
        private void button9_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            using (FileStream fs = new FileStream(f2.puth, FileMode.OpenOrCreate))
            {
                // сериализация (сохранение объекта в поток байт)
                formatter.Serialize(fs, history);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            picture.Image = history.refresh(picture.Image);
            BinaryFormatter formatter = new BinaryFormatter();
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if (File.Exists(f2.puth) == true)
            {
                using (FileStream fs = new FileStream(f2.puth, FileMode.OpenOrCreate))
                {
                    // десериализация (создание объекта из потока байт)
                    UndoRedo train = (UndoRedo)formatter.Deserialize(fs);
                    addingpen(train);
                    history = train;
                }
                if (history.RP == true)
                    figure.truepolygon = history.castil();
                var up = new Bitmap(1000, 540);
                picture.Image = up;
                g = Graphics.FromImage(up);
                history.imageupdate(g);
                bm = up;
                figure.PR = false;
            }
        }

        private void addingpen(UndoRedo train)
        {
            var penny = new Pen(Color.Black);
            train.undopen = new List<Pen>();
            if (train.undoRP.Count!=0)
            {
                for (int i = 0; i < train.undoRP.Count; i++)
                {
                    train.undopen.Add(penny);
                }
            }
            train.redopen = new List<Pen>();
            if (train.redoRP.Count != 0)
            {
                
                for (int i = 0; i < train.redoRP.Count; i++)
                {
                    train.redopen.Add(penny);
                }
            }
        }
    }
}