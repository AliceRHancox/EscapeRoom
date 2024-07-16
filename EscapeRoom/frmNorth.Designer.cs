﻿namespace EscapeRoom
{
    partial class frmNorth
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
            btnWest = new Button();
            btnEast = new Button();
            pictureBox1 = new PictureBox();
            picDoor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDoor).BeginInit();
            SuspendLayout();
            // 
            // btnWest
            // 
            btnWest.BackColor = Color.Transparent;
            btnWest.FlatStyle = FlatStyle.Popup;
            btnWest.ForeColor = Color.White;
            btnWest.Location = new Point(28, 1024);
            btnWest.Margin = new Padding(6, 6, 6, 6);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(156, 70);
            btnWest.TabIndex = 0;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = false;
            btnWest.Click += btnWest_Click;
            // 
            // btnEast
            // 
            btnEast.BackColor = Color.Transparent;
            btnEast.FlatStyle = FlatStyle.Popup;
            btnEast.ForeColor = Color.White;
            btnEast.Location = new Point(1467, 1024);
            btnEast.Margin = new Padding(6, 6, 6, 6);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(156, 70);
            btnEast.TabIndex = 1;
            btnEast.Text = "East";
            btnEast.UseVisualStyleBackColor = false;
            btnEast.Click += btnEast_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(644, 303);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // picDoor
            // 
            picDoor.Image = Properties.Resources.DoorLayout_1;
            picDoor.Location = new Point(644, 315);
            picDoor.Margin = new Padding(6, 6, 6, 6);
            picDoor.Name = "picDoor";
            picDoor.Size = new Size(353, 640);
            picDoor.SizeMode = PictureBoxSizeMode.StretchImage;
            picDoor.TabIndex = 5;
            picDoor.TabStop = false;
            picDoor.Click += picDoor_Click;
            // 
            // frmNorth
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.RoomLayout1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 1090);
            Controls.Add(picDoor);
            Controls.Add(pictureBox1);
            Controls.Add(btnEast);
            Controls.Add(btnWest);
            DoubleBuffered = true;
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmNorth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNorth";
            Load += frmNorth_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDoor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnWest;
        private Button btnEast;
        private PictureBox pictureBox1;
        private PictureBox picDoor;
    }
}