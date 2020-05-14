using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritboken
{
    class PenTool : DrawingTool
    {
        public PenTool(PictureBox picturebox1) : base(picturebox1)
        {
        }

        public override void Draw(Pen p, Graphics g)
        {
            for (int i = 0; i < listOfXY.Count - 1; i++)
            {
                g.DrawLine(Pens.Black, listOfXY[i].X, listOfXY[i].Y, listOfXY[i + 1].X, listOfXY[i + 1].Y);
            }
            g.Dispose();
        }

        public override void MouseDown(int x, int y)
        {
            penDown = true;
            Coordinate c = new Coordinate(x, y);
            listOfXY.Add(c);
        }
        public override void MouseDrag(int x, int y)
        {
            if (penDown == true)
            {
                Bitmap pict = new Bitmap(pictureBox1.BackgroundImage);

                Graphics g = Graphics.FromImage(pict);
                Draw(Pens.Black, g);
                pictureBox1.BackgroundImage = pict;
                Coordinate c = new Coordinate(x, y);
                listOfXY.Add(c);
            }
        }
        public override void MouseUp(int x, int y)
        {
            penDown = false;
            listOfXY.Clear();
            oldBitmaps.Add(pictureBox1.BackgroundImage);
        }
    }
}

