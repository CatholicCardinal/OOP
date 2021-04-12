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

        public bool findoneelemnt1(PointF[] A,PointF B)
        {
            for (int i = 0; A[i].X != 0; i++)
            {
                if (A[i] == B)
                    return false;

            }

            return true;
        }
        public PointF[] findoneelemnt(PointF[] A)
        {
            PointF[] res = new PointF[1000];

            for (int i = 0; A[i].X != 0; i++)
            {
                if (findoneelemnt1(res, A[i]))
                {
                    res[i] = A[i];
                }
            }

            return res;
        }
        public override void fill_color(Pen pen, Graphics g, Point start, Point finish)
        {
            int k = 0;
            g.DrawLine(temp, finish, polygon[0]);


            if (PR == false)
            {
                if (truepolygon != null)
                {
                    var temp = new PointF[1000];
                    //polygon[i] = finish;
                    temp = polygon;
                    temp = delete1(temp, finish);
                    k = numelements(temp);
                    Array.Resize<PointF>(ref polygoncopy, k);
                    polygoncopy = copynum(temp, k);
                    if (polygoncopy.Length != 0)
                        g.FillPolygon(pen.Brush, polygoncopy);
                }
            }
            else
            {
                k = numelements(truepolygon);
                Array.Resize<PointF>(ref polygoncopy, k);
                polygoncopy = copynum(polygon, k);
                polygoncopy[polygoncopy.Length-1]=finish;
                g.FillPolygon(pen.Brush, polygoncopy);
            }
        }

        public PointF[] delete1(PointF[] A, PointF finish)
        {
            int i = 0;
            for (; truepolygon[i].X != 0; i++)
            {
                if (truepolygon[i]!= A[i])
                {
                    A[i] = truepolygon[i];
                }
            }

            A[i] = finish;
            i++;
            for (; i < 1000; i++)
            {
                A[i].X = 0;
                A[i].Y = 0;
            }
            return A;
        }

    }
}
