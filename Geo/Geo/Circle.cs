using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;

namespace Geo
{
    [Serializable]
    public class Circle:Figure
	{
        public override void Draw_picture(Pen pen, Graphics g, Point start, Point finish)
        {
            g.DrawEllipse(pen, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
        }

        public override void fill_color(Pen pen, Graphics g, Point start, Point finish)
        {
            g.FillEllipse(pen.Brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
        }
    }
}