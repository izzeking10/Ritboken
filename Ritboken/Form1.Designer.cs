namespace Ritboken
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLine = new System.Windows.Forms.RadioButton();
            this.btnSquare = new System.Windows.Forms.RadioButton();
            this.btnCircle = new System.Windows.Forms.RadioButton();
            this.btnPen = new System.Windows.Forms.RadioButton();
            this.penSize = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangeColor = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton43 = new System.Windows.Forms.RadioButton();
            this.radioButton45 = new System.Windows.Forms.RadioButton();
            this.radioButton35 = new System.Windows.Forms.RadioButton();
            this.radioButton37 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.Undo = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(290, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 599);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnLine
            // 
            this.btnLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLine.BackColor = System.Drawing.SystemColors.Control;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLine.Location = new System.Drawing.Point(12, 53);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(252, 45);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "Linje";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.CheckedChanged += new System.EventHandler(this.btnLine_CheckedChanged);
            // 
            // btnSquare
            // 
            this.btnSquare.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSquare.BackColor = System.Drawing.SystemColors.Control;
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSquare.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSquare.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSquare.Location = new System.Drawing.Point(12, 118);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(252, 45);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.Text = "Rektangel";
            this.btnSquare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.CheckedChanged += new System.EventHandler(this.btnSquare_CheckedChanged);
            // 
            // btnCircle
            // 
            this.btnCircle.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCircle.BackColor = System.Drawing.SystemColors.Control;
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCircle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCircle.Location = new System.Drawing.Point(12, 183);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(252, 45);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.Text = "Ellips";
            this.btnCircle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.CheckedChanged += new System.EventHandler(this.btnCircle_CheckedChanged);
            // 
            // btnPen
            // 
            this.btnPen.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPen.BackColor = System.Drawing.SystemColors.Control;
            this.btnPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPen.Location = new System.Drawing.Point(12, 247);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(252, 45);
            this.btnPen.TabIndex = 4;
            this.btnPen.Text = "Penna";
            this.btnPen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.CheckedChanged += new System.EventHandler(this.btnPen_CheckedChanged);
            // 
            // penSize
            // 
            this.penSize.Location = new System.Drawing.Point(146, 25);
            this.penSize.Name = "penSize";
            this.penSize.Size = new System.Drawing.Size(100, 26);
            this.penSize.TabIndex = 7;
            this.penSize.Leave += new System.EventHandler(this.penSize_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChangeColor);
            this.groupBox1.Controls.Add(this.radioButton20);
            this.groupBox1.Controls.Add(this.radioButton24);
            this.groupBox1.Controls.Add(this.radioButton12);
            this.groupBox1.Controls.Add(this.radioButton18);
            this.groupBox1.Controls.Add(this.radioButton13);
            this.groupBox1.Controls.Add(this.radioButton15);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton43);
            this.groupBox1.Controls.Add(this.radioButton45);
            this.groupBox1.Controls.Add(this.radioButton35);
            this.groupBox1.Controls.Add(this.radioButton37);
            this.groupBox1.Controls.Add(this.radioButton27);
            this.groupBox1.Controls.Add(this.radioButton29);
            this.groupBox1.Controls.Add(this.radioButton19);
            this.groupBox1.Controls.Add(this.radioButton21);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.penSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 206);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inställningar";
            // 
            // ChangeColor
            // 
            this.ChangeColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChangeColor.Location = new System.Drawing.Point(23, 84);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(26, 24);
            this.ChangeColor.TabIndex = 85;
            this.ChangeColor.TabStop = true;
            this.ChangeColor.UseVisualStyleBackColor = false;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton20
            // 
            this.radioButton20.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton20.BackColor = System.Drawing.Color.Yellow;
            this.radioButton20.Location = new System.Drawing.Point(23, 114);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(26, 24);
            this.radioButton20.TabIndex = 84;
            this.radioButton20.TabStop = true;
            this.radioButton20.UseVisualStyleBackColor = false;
            this.radioButton20.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton24
            // 
            this.radioButton24.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton24.ForeColor = System.Drawing.Color.Coral;
            this.radioButton24.Location = new System.Drawing.Point(23, 144);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(26, 24);
            this.radioButton24.TabIndex = 82;
            this.radioButton24.TabStop = true;
            this.radioButton24.UseVisualStyleBackColor = false;
            this.radioButton24.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton12
            // 
            this.radioButton12.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton12.BackColor = System.Drawing.Color.Teal;
            this.radioButton12.Location = new System.Drawing.Point(55, 84);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(26, 24);
            this.radioButton12.TabIndex = 80;
            this.radioButton12.TabStop = true;
            this.radioButton12.UseVisualStyleBackColor = false;
            this.radioButton12.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton18
            // 
            this.radioButton18.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton18.BackColor = System.Drawing.Color.SaddleBrown;
            this.radioButton18.ForeColor = System.Drawing.Color.Coral;
            this.radioButton18.Location = new System.Drawing.Point(183, 145);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(26, 24);
            this.radioButton18.TabIndex = 62;
            this.radioButton18.TabStop = true;
            this.radioButton18.UseVisualStyleBackColor = false;
            this.radioButton18.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton13
            // 
            this.radioButton13.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton13.BackColor = System.Drawing.Color.Aqua;
            this.radioButton13.Location = new System.Drawing.Point(55, 114);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(26, 24);
            this.radioButton13.TabIndex = 79;
            this.radioButton13.TabStop = true;
            this.radioButton13.UseVisualStyleBackColor = false;
            this.radioButton13.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton15
            // 
            this.radioButton15.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButton15.ForeColor = System.Drawing.Color.Coral;
            this.radioButton15.Location = new System.Drawing.Point(55, 144);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(26, 24);
            this.radioButton15.TabIndex = 77;
            this.radioButton15.TabStop = true;
            this.radioButton15.UseVisualStyleBackColor = false;
            this.radioButton15.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton7.BackColor = System.Drawing.Color.Black;
            this.radioButton7.ForeColor = System.Drawing.Color.Coral;
            this.radioButton7.Location = new System.Drawing.Point(183, 85);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(26, 24);
            this.radioButton7.TabIndex = 75;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = false;
            this.radioButton7.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton43
            // 
            this.radioButton43.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButton43.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton43.Location = new System.Drawing.Point(151, 84);
            this.radioButton43.Name = "radioButton43";
            this.radioButton43.Size = new System.Drawing.Size(26, 24);
            this.radioButton43.TabIndex = 73;
            this.radioButton43.TabStop = true;
            this.radioButton43.UseVisualStyleBackColor = false;
            this.radioButton43.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton45
            // 
            this.radioButton45.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton45.BackColor = System.Drawing.Color.Blue;
            this.radioButton45.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton45.Location = new System.Drawing.Point(151, 114);
            this.radioButton45.Name = "radioButton45";
            this.radioButton45.Size = new System.Drawing.Size(26, 24);
            this.radioButton45.TabIndex = 72;
            this.radioButton45.TabStop = true;
            this.radioButton45.UseVisualStyleBackColor = false;
            this.radioButton45.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton35
            // 
            this.radioButton35.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton35.Location = new System.Drawing.Point(119, 84);
            this.radioButton35.Name = "radioButton35";
            this.radioButton35.Size = new System.Drawing.Size(26, 24);
            this.radioButton35.TabIndex = 69;
            this.radioButton35.TabStop = true;
            this.radioButton35.UseVisualStyleBackColor = false;
            this.radioButton35.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton37
            // 
            this.radioButton37.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton37.Location = new System.Drawing.Point(119, 145);
            this.radioButton37.Name = "radioButton37";
            this.radioButton37.Size = new System.Drawing.Size(26, 24);
            this.radioButton37.TabIndex = 68;
            this.radioButton37.TabStop = true;
            this.radioButton37.UseVisualStyleBackColor = false;
            this.radioButton37.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton27
            // 
            this.radioButton27.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton27.BackColor = System.Drawing.Color.Fuchsia;
            this.radioButton27.Location = new System.Drawing.Point(87, 84);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(26, 24);
            this.radioButton27.TabIndex = 65;
            this.radioButton27.TabStop = true;
            this.radioButton27.UseVisualStyleBackColor = false;
            this.radioButton27.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton29
            // 
            this.radioButton29.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioButton29.Location = new System.Drawing.Point(87, 114);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(26, 24);
            this.radioButton29.TabIndex = 64;
            this.radioButton29.TabStop = true;
            this.radioButton29.UseVisualStyleBackColor = false;
            this.radioButton29.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton19
            // 
            this.radioButton19.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioButton19.ForeColor = System.Drawing.Color.Coral;
            this.radioButton19.Location = new System.Drawing.Point(151, 144);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(26, 24);
            this.radioButton19.TabIndex = 61;
            this.radioButton19.TabStop = true;
            this.radioButton19.UseVisualStyleBackColor = false;
            this.radioButton19.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton21
            // 
            this.radioButton21.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButton21.ForeColor = System.Drawing.Color.Coral;
            this.radioButton21.Location = new System.Drawing.Point(87, 144);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(26, 24);
            this.radioButton21.TabIndex = 60;
            this.radioButton21.TabStop = true;
            this.radioButton21.UseVisualStyleBackColor = false;
            this.radioButton21.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton10
            // 
            this.radioButton10.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton10.BackColor = System.Drawing.Color.Lime;
            this.radioButton10.Location = new System.Drawing.Point(119, 114);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(26, 24);
            this.radioButton10.TabIndex = 58;
            this.radioButton10.TabStop = true;
            this.radioButton10.UseVisualStyleBackColor = false;
            this.radioButton10.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // radioButton8
            // 
            this.radioButton8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton8.Location = new System.Drawing.Point(183, 115);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(26, 24);
            this.radioButton8.TabIndex = 57;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = false;
            this.radioButton8.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // Undo
            // 
            this.Undo.ForeColor = System.Drawing.Color.Red;
            this.Undo.Location = new System.Drawing.Point(12, 354);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(252, 45);
            this.Undo.TabIndex = 57;
            this.Undo.Text = "Ångra";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Fill
            // 
            this.Fill.Appearance = System.Windows.Forms.Appearance.Button;
            this.Fill.BackColor = System.Drawing.SystemColors.Control;
            this.Fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Fill.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fill.Location = new System.Drawing.Point(12, 298);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(252, 45);
            this.Fill.TabIndex = 58;
            this.Fill.Text = "Fyll";
            this.Fill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Fill.UseVisualStyleBackColor = false;
            this.Fill.CheckedChanged += new System.EventHandler(this.Fill_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 623);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Ritboken";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton btnLine;
        private System.Windows.Forms.RadioButton btnSquare;
        private System.Windows.Forms.RadioButton btnCircle;
        private System.Windows.Forms.RadioButton btnPen;
        private System.Windows.Forms.TextBox penSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.RadioButton ChangeColor;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton43;
        private System.Windows.Forms.RadioButton radioButton45;
        private System.Windows.Forms.RadioButton radioButton35;
        private System.Windows.Forms.RadioButton radioButton37;
        private System.Windows.Forms.RadioButton radioButton27;
        private System.Windows.Forms.RadioButton radioButton29;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton Fill;
    }
}

