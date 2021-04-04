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
    public class BrokenLine : Figure
    {

        public override void Draw_picture(Pen pen, Graphics g, Point start, Point finish)
        {
            if (ending.X == 0)
            {
                g.DrawLine(pen, start, finish);
            }
            else
            {
                
                g.DrawLine(pen, ending, finish);
            }
        }

        public override void fill_color(Pen pen, Graphics g, Point start, Point finish)
        {

        }
    }
}
