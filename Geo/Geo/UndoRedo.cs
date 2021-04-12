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
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Concurrent;



namespace Geo
{
	public class UndoRedo
	{
		public List<Figure> Undo = new List<Figure>();
		public List<Figure> Redo = new List<Figure>();
		private List<Point> undostart = new List<Point>();
		private List<Point> undofinish = new List<Point>();
		private List<Point> redostart = new List<Point>();
		private List<Point> redofinish = new List<Point>();

		private List<Pen> undopen = new List<Pen>();
		private List<Pen> redopen = new List<Pen>();

		private List<Color> undopen1 = new List<Color>();
		private List<Color> redopen1 = new List<Color>();

		private List<int> undowidth = new List<int>();
		private List<int> redowidth = new List<int>();

		private List<bool> undoBL = new List<bool>();
		private List<bool> redoBL = new List<bool>();
		public bool BL = false;

		private List<bool> undoRP = new List<bool>();
		private List<bool> redoRP = new List<bool>();
		public bool RP = false;

		public Image refresh(Image image)
        {
			image = null;
			return (image);
        }

		public void cleanall()
        {
			Redo.Clear();
			redostart.Clear();
			redofinish.Clear();
			redopen.Clear();
			redopen1.Clear();
			redoBL.Clear();
			redoRP.Clear();
		}

		public void addundo(Figure figure)
        {
			Undo.Add(figure);
        }

		public void addstart(Point start)
		{
			undostart.Add(start);
		}

		public void addfinish(Point finish)
		{
			undofinish.Add(finish);
		}

		public void addpen(Pen pen)
		{
			undopen.Add(pen);
		}

		public void addpen1(Color pen1)
		{
			undopen1.Add(pen1);
		}

		public void addwidth(int width)
		{
			undowidth.Add(width);
		}

		public void addBL(bool fl)
		{
			undoBL.Add(fl);
		}

		public void addRP(bool fl)
		{
			undoRP.Add(fl);
		}
		//-------------------------------------------------------
		public void redo()
		{
			if (Undo.Count != 0)
			{
				Redo.Add(Undo[Undo.Count - 1]);
				Undo.RemoveAt(Undo.Count - 1);
				redostart.Add(undostart[undostart.Count-1]);
				undostart.RemoveAt(undostart.Count - 1);
				redofinish.Add(undofinish[undofinish.Count - 1]);
				undofinish.RemoveAt(undofinish.Count - 1);

				redopen.Add(undopen[undopen.Count - 1]);
				undopen.RemoveAt(undopen.Count - 1);

				redopen1.Add(undopen1[undopen1.Count - 1]);
				undopen1.RemoveAt(undopen1.Count - 1);

				redowidth.Add(undowidth[undowidth.Count - 1]);
				undowidth.RemoveAt(undowidth.Count - 1);

				redoBL.Add(undoBL[undoBL.Count - 1]);
				undoBL.RemoveAt(undoBL.Count - 1);

				redoRP.Add(undoRP[undoRP.Count - 1]);
				undoRP.RemoveAt(undoRP.Count - 1);
			}
		}

		public void undo()
		{
			if (Redo.Count != 0)
			{
				Undo.Add(Redo[Redo.Count - 1]);
				Redo.RemoveAt(Redo.Count - 1);

				undostart.Add(redostart[redostart.Count - 1]);
				redostart.RemoveAt(redostart.Count - 1);
				undofinish.Add(redofinish[redofinish.Count - 1]);
				redofinish.RemoveAt(redofinish.Count - 1);

				undopen.Add(redopen[redopen.Count - 1]);
				redopen.RemoveAt(redopen.Count - 1);

				undopen1.Add(redopen1[redopen1.Count - 1]);
				redopen1.RemoveAt(redopen1.Count - 1);

				undowidth.Add(redowidth[redowidth.Count - 1]);
				redowidth.RemoveAt(redowidth.Count - 1);

				undoBL.Add(redoBL[redoBL.Count - 1]);
				redoBL.RemoveAt(redoBL.Count - 1);

				undoRP.Add(redoRP[redoRP.Count - 1]);
				redoRP.RemoveAt(redoRP.Count - 1);
			}
			
		}

		public void imageupdate(Graphics g)
        {
			int i = 0;
			while(i<Undo.Count)
            {
				BL = undoBL[i];
				RP = undoRP[i];

				undopen[i].Width = undowidth[i];
				if (BL == true || RP == true)
				{
					if (BL == true)
						BLdrawing(g, i);
					if (RP == true)
						RPdrawing(g, i);
				}
				else
				{
					Undo[i].Draw_picture(undopen[i], g, undostart[i], undofinish[i]);
				}
				if (RP != true)
				{
					var color = new Color();
					color = undopen[i].Color;
					undopen[i].Color = undopen1[i];
					Undo[i].fill_color(undopen[i], g, undostart[i], undofinish[i]);
					undopen[i].Color = color;
				}
				i++;
            }
        }

		private void BLdrawing(Graphics g, int i)
		{
			if (i == 0 || undoBL[i-1]== false)
				Undo[i].ending.X =0; 
			else
				Undo[i].ending = undofinish[i - 1];
			if (i == 0 || undoBL[i - 1] == false)
				Undo[i].Draw_picture(undopen[i], g, undostart[i], undofinish[i]);
			else
				Undo[i].Draw_picture(undopen[i], g, undofinish[i - 1], undofinish[i]);
			Undo[i].ending = undofinish[i];
		}

		private void RPdrawing(Graphics g, int i)
		{
            if (undoRP[i - 1] == false)
            {

            }
			if (i == 0) //|| undoRP[i - 1]==false)
				Undo[i].ending.X = 0;
			else
				Undo[i].ending = undofinish[i - 1];
			if (i == 0) //|| undoRP[i - 1]==false)
				Undo[i].Draw_picture(undopen[i], g, undostart[i], undofinish[i]);
			else
				Undo[i].Draw_picture(undopen[i], g, undofinish[i - 1], undofinish[i]);

			if (i==Undo.Count-1)
            {
				var color = new Color();
				color = undopen[i].Color;
				undopen[i].Color = undopen1[i];
				Undo[i].fill_color(undopen[i], g, undostart[i], undofinish[i]);
				undopen[i].Color = color;
			}
			Undo[i].ending = undofinish[i];
		}

		

		public PointF[] castil()
        {
			if (Undo.Count != 0)
			{
				var polygon = new PointF[1000];
				int i = 0, j = 0;
				polygon[j] = undostart[i];
				j++;
				for (; i < undofinish.Count; i++, j++)
				{
					polygon[j] = undofinish[i];
				}

				return polygon;
			}
			return null;
		}
	}
}
