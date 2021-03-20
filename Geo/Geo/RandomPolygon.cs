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
    public class RandomPolygon : Figure
    {
        public PointF[] polygon = new PointF[1000], polygoncopy = new PointF[1000];
        private int i=0;
        public override void Draw_picture(Pen pen, Graphics g, Point start, Point finish)
        {
            if (ending.X == 0)
            {
                g.DrawLine(pen, start, finish);
                if (polygon[0].X== 0)
                {
                    polygon[i] = start;
                    i++;
                }
                if ((polygon[i - 1] != ending) & (ending.X!=0))
                {
                    polygon[i] = ending;
                    i++;
                }
            }
            else
            {
                g.DrawLine(pen, ending, finish);
                if (polygon[i - 1] != ending)
                {
                    polygon[i] = ending;
                    i++;
                }
            }
        }

        public int numelements(PointF[] A)
        {
            int i;
            for ( i = 0; (i < A.Length)&(A[i].X!=0); i++)
            {
                if ( (i+1) == A.Length)
                {
                    break;
                }
            }
            return i;
        }

        public PointF[] copynum(PointF[] A, int k)
        {
            PointF[] res = new PointF[k];

            for (int i = 0; i < k; i++)
            {
                res[i] = A[i];
            }

            return res;
        }

        public override void fill_color(Pen pen, Graphics g, Point start, Point finish)
        {
            int k = 0;
            g.DrawLine(temp, finish, polygon[0]);
            polygon[i] = finish;
            k = numelements(polygon);
            Array.Resize<PointF>(ref polygoncopy, k);
            polygoncopy = copynum(polygon, k);
            g.FillPolygon(pen.Brush, polygoncopy);
        }
    }
}
