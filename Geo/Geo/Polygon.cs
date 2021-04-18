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
    [Serializable]
    public class Polygon : Figure
    {
        private static void DrawRegularPolygon(PointF center, int vertexes, float radius, Graphics graphics, Pen pen)
        {
            var angle = Math.PI * 2 / vertexes;

            var points = Enumerable.Range(0, vertexes)
                  .Select(i => PointF.Add(center, new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius)));

            graphics.DrawPolygon(pen, points.ToArray());
        }

        public override void Draw_picture(Pen pen, Graphics g, Point start, Point finish)
        {
            PointF point1 = new PointF(start.X, start.Y);
            DrawRegularPolygon(point1, k, (finish.X - start.X) + (finish.X - start.X), g, pen);
        }

        private void big_brains(PointF center, int vertexes, float radius, Graphics graphics, Pen pen)
        {
            var angle = Math.PI * 2 / vertexes;

            var points = Enumerable.Range(0, vertexes)
                  .Select(i => PointF.Add(center, new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius)));

            graphics.FillPolygon(pen.Brush, points.ToArray());
        }
        public override void fill_color(Pen pen, Graphics g, Point start, Point finish)
        {
       
            PointF point1 = new PointF(start.X, start.Y);
            big_brains(point1, k, (finish.X - start.X) + (finish.X - start.X), g, pen);
        }
    }
}
