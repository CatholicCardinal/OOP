using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Text.RegularExpressions;



namespace Geo
{
	public abstract class Figure
    {
        public void color_border(bool check, string text, Pen pen)
        {
            if (check == true)
            {
                if (text == "Черный")
                {
                    pen.Color = Color.Black;
                }

                if (text == "Белый")
                {
                    pen.Color = Color.White;
                }

                if (text == "Зеленый")
                {
                    pen.Color = Color.Green;
                }

                if (text == "Синий")
                {
                    pen.Color = Color.Blue;
                }

                if (text == "Красный")
                {
                    pen.Color = Color.Red;
                }

                if (text == "Жёлтый")
                {
                    pen.Color = Color.Yellow;
                }
            }
            else 
                pen.Color = Color.White;
        }
		public void width_border(bool check, string text, Pen pen)
        {
            Regex regex1 = new Regex("^[0-9]+$");
            if ((check == true) & (regex1.IsMatch(text) == true))
            {
                pen.Width = int.Parse(text);

            }
            else 
                pen.Width = 3;
        }
        public void cheking_fill_color(bool check, string text,Pen pen, Graphics g, Point start, Point finish)
        {
            if (check == true)
            {
                if (text == "Черный")
                {
                    pen.Color = Color.Black;
                }

                if (text == "Белый")
                {
                    pen.Color = Color.White;

                }

                if (text == "Зеленый")
                {
                    pen.Color = Color.Green;

                }

                if (text == "Синий")
                {
                    pen.Color = Color.Blue;
                }

                if (text == "Красный")
                {
                    pen.Color = Color.Red;
                }

                if (text == "Жёлтый")
                {
                    pen.Color = Color.Yellow;
                }
            } 
            else
            {
                pen.Color = Color.White;
            }
        }


        public abstract void fill_color(Pen pen, Graphics g, Point start, Point finish);
        public abstract void Draw_picture(Pen pen, Graphics g, Point start, Point finish);


        public int k = 5;
        public Point ending = new Point();
        public Point starting = new Point();
        public Pen temp = new Pen(Color.Black);
        public void number(string text)
        {
            Regex regex1 = new Regex("^[0-9]+$");
            if (regex1.IsMatch(text) == true)
            {
                k = int.Parse(text);
            }
            else
            {
                k = 3;
            }
        }

        public Stack<Point> undostack = new Stack<Point>(), redostack = new Stack<Point>();
        public bool undo = false;
    }
}