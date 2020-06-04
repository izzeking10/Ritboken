using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritboken
{
    public partial class Form1 : Form
    {
        DrawingTool drawingTool;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// checks if the user is pressing down a mouse key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (drawingTool != null)
            {
                drawingTool.MouseDown(e.X, e.Y);
            }

        }
        /// <summary>
        /// checks if the user is letting go of a mouse key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawingTool != null)
            {
                drawingTool.MouseUp(e.X, e.Y);
            }
        }
        /// <summary>
        /// makes it so that you have to choose a tool to choose colors
        /// </summary>
        private void showColors()
        {             
            foreach (RadioButton tb in this.Controls.OfType<RadioButton>())
            {
                if (tb.Tag as string == "1")
                {
                    tb.Visible = true;
                }
            }
        }
 /// <summary>
 /// checks if the user is moving the mouse
 /// </summary>
 /// <param name="sender"></param>
 /// <param name="e"></param>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingTool != null)
            {
                drawingTool.MouseDrag(e.X, e.Y);
            }
        }
        /// <summary>
        /// sets drawingtool to the Pentool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPen_CheckedChanged(object sender, EventArgs e)
        {
            drawingTool = new PenTool(pictureBox1);
            showColors();
        }
        /// <summary>
        /// sets drawingtool to the Linetool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLine_CheckedChanged(object sender, EventArgs e)
        {
            drawingTool = new LineTool(pictureBox1);
            showColors();
        }
        /// <summary>
        /// sets drawingtool to the Squaretool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSquare_CheckedChanged(object sender, EventArgs e)
        {
            drawingTool = new SquareTool(pictureBox1);
            showColors();
        }
        /// <summary>
        /// sets drawingtool to the Circletool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCircle_CheckedChanged(object sender, EventArgs e)
        {
            drawingTool = new CircleTool(pictureBox1);
            showColors();
        }
        /// <summary>
        /// removes everything drawn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Undo_Click(object sender, EventArgs e)
        {
            if (drawingTool != null)
            {
                drawingTool.Undo();
            }
        }
        /// <summary>
        /// checks what color the user want to use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeColor_Click(object sender, EventArgs e)
        {
            if ((sender is RadioButton) && (drawingTool != null))
            {
                RadioButton b = sender as RadioButton;
                DrawingTool.pen.Color = b.BackColor;
            }
        }
        /// <summary>
        /// checks what size the player wants for the pen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void penSize_Leave(object sender, EventArgs e)
        {
            try
            {
                DrawingTool.pen.Width = Convert.ToInt32(penSize.Text);
            }
            catch (Exception)
            {
                penSize.Text = "1";
                DrawingTool.pen.Width = 1;
            }
        }
        /// <summary>
        /// sets drawingtool to the Polygontool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fill_CheckedChanged(object sender, EventArgs e)
        {
            drawingTool = new DrawPolygon(pictureBox1);
            showColors();
        }
    }
}
