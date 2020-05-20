using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritboken
{
    class SquareTool : DrawingTool
    {
        public SquareTool(PictureBox picturebox1) : base(picturebox1)
        {

        }
        public override void Draw(Pen p, Graphics g)
        {
          int maxX = Math.Max(Math.Max(listOfXY[0].X, listOfXY[1].X), Math.Max(listOfXY[2].X, listOfXY[3].X));
          int minX = Math.Min(Math.Min(listOfXY[0].X, listOfXY[1].X), Math.Min(listOfXY[2].X, listOfXY[3].X));
          int maxY = Math.Max(Math.Max(listOfXY[0].Y, listOfXY[1].Y), Math.Max(listOfXY[2].Y, listOfXY[3].Y));
          int minY = Math.Min(Math.Min(listOfXY[0].Y, listOfXY[1].Y), Math.Min(listOfXY[2].Y, listOfXY[3].Y));
          int width = maxX - minX;
          int height = maxY - minY;
            Rectangle rectangle = new Rectangle(minX, minY, width, height);
            g.DrawRectangle(Pens.Black, rectangle);
            g.Dispose();
        }
        public override void MouseDown(int x, int y)
        { 
            Coordinate c = new Coordinate(x, y);
            listOfXY.Add(c);
        }
        public override void MouseDrag(int x, int y)
        {

        }
        public override void MouseUp(int x, int y)
        {
            Coordinate first = listOfXY[0];
            listOfXY.Add(new Coordinate(first.X, y));
            listOfXY.Add(new Coordinate(x, y));
            listOfXY.Add(new Coordinate(x, first.Y));

            Bitmap pict = new Bitmap(pictureBox1.BackgroundImage);

            Graphics g = Graphics.FromImage(pict);
            Draw(Pens.Black, g);
            pictureBox1.BackgroundImage = pict;

            listOfXY.Clear();
            
        }
    }
    }

