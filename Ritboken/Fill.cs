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
            if (listOfXY.Count == 3)
            {
                PointF point1 = new PointF(listOfXY[0].X, listOfXY[0].Y);
                PointF point2 = new PointF(listOfXY[1].X, listOfXY[1].Y);
                PointF point3 = new PointF(listOfXY[2].X, listOfXY[2].Y);
                PointF[] curvePoints =
                {
                point1,
                point2,
                point3
            };
                g.FillPolygon(p.Brush, curvePoints);
                listOfXY.Clear();
            }
            
           
        }
        public override void MouseDown(int x, int y)
        {
            Bitmap pict = new Bitmap(pictureBox1.BackgroundImage);
            Graphics g = Graphics.FromImage(pict);
            Coordinate c = new Coordinate(x, y);
            listOfXY.Add(c);
            Draw(pen, g);
            pictureBox1.BackgroundImage = pict;}
        public override void MouseDrag(int x, int y)
        {

        }
        public override void MouseUp(int x, int y)
        {

        }

    }
}
