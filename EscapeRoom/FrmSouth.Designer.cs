﻿namespace EscapeRoom
{
    partial class frmSouth
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
            components = new System.ComponentModel.Container();
            btnEast = new Button();
            btnWest = new Button();
            picBookShelf = new PictureBox();
            btnEnd = new Button();
            tmrTime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picBookShelf).BeginInit();
            SuspendLayout();
            // 
            // btnEast
            // 
            btnEast.BackColor = Color.Transparent;
            btnEast.FlatStyle = FlatStyle.Popup;
            btnEast.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEast.ForeColor = Color.White;
            btnEast.Location = new Point(28, 1024);
            btnEast.Margin = new Padding(6);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(156, 70);
            btnEast.TabIndex = 1;
            btnEast.Text = "East";
            btnEast.UseVisualStyleBackColor = false;
            btnEast.Click += btnEast_Click;
            // 
            // btnWest
            // 
            btnWest.BackColor = Color.Transparent;
            btnWest.FlatStyle = FlatStyle.Popup;
            btnWest.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWest.ForeColor = Color.White;
            btnWest.Location = new Point(1467, 1024);
            btnWest.Margin = new Padding(6);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(156, 70);
            btnWest.TabIndex = 2;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = false;
            btnWest.Click += btnWest_Click;
            // 
            // picBookShelf
            // 
            picBookShelf.BackColor = Color.Transparent;
            picBookShelf.Image = Properties.Resources.Bookshelf_layout_1;
            picBookShelf.Location = new Point(282, 420);
            picBookShelf.Margin = new Padding(6);
            picBookShelf.Name = "picBookShelf";
            picBookShelf.Size = new Size(1081, 529);
            picBookShelf.SizeMode = PictureBoxSizeMode.StretchImage;
            picBookShelf.TabIndex = 3;
            picBookShelf.TabStop = false;
            picBookShelf.Click += picBookShelf_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(1319, 13);
            btnEnd.Margin = new Padding(4, 2, 4, 2);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(182, 47);
            btnEnd.TabIndex = 8;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // tmrTime
            // 
            tmrTime.Enabled = true;
            tmrTime.Tick += tmrTime_Tick;
            // 
            // frmSouth
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RoomLayout1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 1090);
            Controls.Add(btnEnd);
            Controls.Add(picBookShelf);
            Controls.Add(btnWest);
            Controls.Add(btnEast);
            DoubleBuffered = true;
            Margin = new Padding(6);
            Name = "frmSouth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSouth";
            Load += frmSouth_Load;
            ((System.ComponentModel.ISupportInitialize)picBookShelf).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEast;
        private Button btnWest;
        private PictureBox picBookShelf;
        private Button btnEnd;
        private System.Windows.Forms.Timer tmrTime;
    }
}