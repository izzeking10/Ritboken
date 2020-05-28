using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritboken
{
    class DrawPolygon : DrawingTool
    {
        public DrawPolygon(PictureBox picturebox1) : base(picturebox1)
        {

        }
        public override void Draw(Pen p, Graphics g)
        {
            if (points == 3)
            {
                g.DrawPolygon(pen, curvePoints);
            }
           
        }
        public override void MouseDown(int x, int y)
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
            penDown = true;
            Coordinate c = new Coordinate(x, y);
            listOfXY.Add(c);
        }
        public override void MouseDrag(int x, int y)
        {

        }
        public override void MouseUp(int x, int y)
        {
            penDown = false;
            Coordinate c = new Coordinate(x, y);
            listOfXY.Add(c);
            Bitmap pict = new Bitmap(pictureBox1.BackgroundImage);

            Graphics g = Graphics.FromImage(pict);
            Draw(Pens.Black, g);
            pictureBox1.BackgroundImage = pict;
            listOfXY.Clear();
            oldBitmaps.Add(pictureBox1.BackgroundImage);
        }

    }
}
