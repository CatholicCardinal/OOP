using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Text;
using System.Data;
using System.ComponentModel;
using Geo;

namespace TrapeziumPlugin
{
    [Serializable]
    public class Trapezi : Figure
    {
        private PointF[] trp;
        public override void Draw_picture(Pen pen, Graphics g, Point start, Point finish)
        {
            var localpen = new Pen(pen.Color);
            localpen.Width = pen.Width;
            Point p3 = new Point(finish.X - 50, start.Y);
            Point p4 = new Point(start.X - 50, finish.Y);
            g.DrawLine(localpen, start, p3);
            g.DrawLine(localpen, p3, finish);
            g.DrawLine(localpen, finish, p4);
            g.DrawLine(localpen, start, p4);
            trp = new PointF[4];
            trp[0] = new Point { X = start.X, Y = start.Y };
            trp[2] = new Point { X = finish.X, Y = finish.Y };
            trp[1] = new Point { X = p3.X, Y = p3.Y };
            trp[3] = new Point { X = p4.X, Y = p4.Y };
        }

        public override void fill_color(Pen pen, Graphics g, Point start, Point finish)
        {
            g.FillPolygon(pen.Brush, trp);
        }
    }
}
