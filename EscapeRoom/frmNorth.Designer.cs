namespace EscapeRoom
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
            lblProgress = new Label();
            btnEnd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDoor).BeginInit();
            SuspendLayout();
            // 
            // btnWest
            // 
            btnWest.BackColor = Color.Transparent;
            btnWest.FlatStyle = FlatStyle.Popup;
            btnWest.ForeColor = Color.White;
            btnWest.Location = new Point(15, 480);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(84, 33);
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
            btnEast.Location = new Point(790, 480);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(84, 33);
            btnEast.TabIndex = 1;
            btnEast.Text = "East";
            btnEast.UseVisualStyleBackColor = false;
            btnEast.Click += btnEast_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(347, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // picDoor
            // 
            picDoor.Image = Properties.Resources.DoorLayout_1;
            picDoor.Location = new Point(344, 148);
            picDoor.Name = "picDoor";
            picDoor.Size = new Size(190, 300);
            picDoor.SizeMode = PictureBoxSizeMode.StretchImage;
            picDoor.TabIndex = 5;
            picDoor.TabStop = false;
            picDoor.Click += picDoor_Click;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.ForeColor = Color.White;
            lblProgress.Location = new Point(385, 103);
            lblProgress.Margin = new Padding(2, 0, 2, 0);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(0, 15);
            lblProgress.TabIndex = 6;
            lblProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Transparent;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(715, 6);
            btnEnd.Margin = new Padding(2, 1, 2, 1);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(98, 22);
            btnEnd.TabIndex = 8;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click_1;
            // 
            // frmNorth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.RoomLayout1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 511);
            Controls.Add(btnEnd);
            Controls.Add(lblProgress);
            Controls.Add(picDoor);
            Controls.Add(pictureBox1);
            Controls.Add(btnEast);
            Controls.Add(btnWest);
            DoubleBuffered = true;
            Name = "frmNorth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNorth";
            Load += frmNorth_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDoor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWest;
        private Button btnEast;
        private PictureBox pictureBox1;
        private PictureBox picDoor;
        private Label lblProgress;
        private Button btnEnd;
    }
}