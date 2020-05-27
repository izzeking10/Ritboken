﻿using System;
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (drawingTool != null)
            {
                drawingTool.MouseDown(e.X, e.Y);
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawingTool != null)
            {
                drawingTool.MouseUp(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingTool != null)
            {
                drawingTool.MouseDrag(e.X, e.Y);
            }
        }

        private void btnPen_CheckedChanged(object sender, EventArgs e)
        {
            drawingTool = new PenTool(pictureBox1);
        }

        private void btnLine_CheckedChanged(object sender, EventArgs e)
        {
            drawingTool = new LineTool(pictureBox1);
        }

        private void btnSquare_CheckedChanged(object sender, EventArgs e)
        {
            drawingTool = new SquareTool(pictureBox1);
        }

        private void btnCircle_CheckedChanged(object sender, EventArgs e)
        {
            drawingTool = new CircleTool(pictureBox1);
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (drawingTool != null)
            {
                drawingTool.Undo();
            }
        }

        private void penSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            if ((sender is RadioButton) && (drawingTool != null))
            {
                RadioButton b = (sender as RadioButton);
                DrawingTool.pen.Color = b.BackColor;
            }
        }
    }
}
