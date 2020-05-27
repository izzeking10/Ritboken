using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritboken
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public abstract class DrawingTool
    {
        protected PictureBox pictureBox1;
        protected List<Coordinate> listOfXY;
        static public Pen pen = new Pen(Color.Black);
        protected bool penDown = false;

        protected List<Image> oldBitmaps = new List<Image>();

        public DrawingTool(PictureBox pictureBox)
        {
            this.pictureBox1 = pictureBox;
            if (pictureBox1.BackgroundImage == null)
            {
                Bitmap pict = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.BackgroundImage = pict;
            }
            this.listOfXY = new List<Coordinate>();
        }
        public abstract void MouseDown(int x, int y);
        public abstract void MouseUp(int x, int y);
        public abstract void MouseDrag(int x, int y);
        public abstract void Draw(Pen p, Graphics g);

        public void Undo()
        {
            oldBitmaps.RemoveAt(oldBitmaps.Count - 1);
            if (oldBitmaps.Count == 0)
            {
                Bitmap pict = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                oldBitmaps.Add(pict);
            }
            pictureBox1.BackgroundImage = oldBitmaps[oldBitmaps.Count - 1];
        }
    }
}
