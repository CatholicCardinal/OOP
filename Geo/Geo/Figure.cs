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
        public bool drawing = false;

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
        }
		public void width_border(bool check, string text, Pen pen)
        {
            if (check == true)
            {
                pen.Width = int.Parse(text);

            }
        }

        public abstract void fill_color(Pen pen, Graphics g, Point start, Point finish);

        public void cheking_fill_color(bool check, string text,Pen pen, Graphics g, Point start, Point finish)
        {
            if (check == true)
            {
                if (text == "Черный")
                {
                    pen.Color = Color.Black;
                    fill_color(pen, g, start, finish);
                }

                if (text == "Белый")
                {
                    pen.Color = Color.White;
                    fill_color(pen, g, start, finish);
                }

                if (text == "Зеленый")
                {
                    pen.Color = Color.Green;
                    fill_color(pen, g, start, finish);
                }

                if (text == "Синий")
                {
                    pen.Color = Color.Blue;
                    fill_color(pen, g, start, finish);
                }

                if (text == "Красный")
                {
                    pen.Color = Color.Red;
                    fill_color(pen, g, start, finish);
                }

                if (text == "Жёлтый")
                {
                    pen.Color = Color.Yellow;
                    fill_color(pen, g, start, finish);
                }
            }
        }

        public abstract void Draw_picture(Pen pen, Graphics g, Point start, Point finish);

        public int k = 5;

        public void number(string text)
        {
            if (text != "")
            {
                k = int.Parse(text);
            }
            else
            {
                k = 3;
            }

        }


    }
}