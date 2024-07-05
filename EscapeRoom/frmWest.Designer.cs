namespace EscapeRoom
{
    partial class frmWest
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
            btnNorth = new Button();
            btnSouth = new Button();
            picPainting = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPainting).BeginInit();
            SuspendLayout();
            // 
            // btnNorth
            // 
            btnNorth.BackColor = Color.Transparent;
            btnNorth.FlatStyle = FlatStyle.Popup;
            btnNorth.ForeColor = Color.White;
            btnNorth.Location = new Point(790, 480);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(84, 33);
            btnNorth.TabIndex = 1;
            btnNorth.Text = "North";
            btnNorth.UseVisualStyleBackColor = false;
            btnNorth.Click += btnNorth_Click;
            // 
            // btnSouth
            // 
            btnSouth.BackColor = Color.Transparent;
            btnSouth.FlatStyle = FlatStyle.Popup;
            btnSouth.ForeColor = Color.White;
            btnSouth.Location = new Point(15, 480);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(84, 33);
            btnSouth.TabIndex = 2;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = false;
            btnSouth.Click += btnSouth_Click;
            // 
            // picPainting
            // 
            picPainting.Image = Properties.Resources.Painting_layout_1;
            picPainting.Location = new Point(335, 59);
            picPainting.Name = "picPainting";
            picPainting.Size = new Size(200, 170);
            picPainting.TabIndex = 3;
            picPainting.TabStop = false;
            picPainting.Click += picPainting_Click;
            // 
            // frmWest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RoomLayout1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 511);
            Controls.Add(picPainting);
            Controls.Add(btnSouth);
            Controls.Add(btnNorth);
            DoubleBuffered = true;
            Name = "frmWest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmWest";
            ((System.ComponentModel.ISupportInitialize)picPainting).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNorth;
        private Button btnSouth;
        private PictureBox picPainting;
    }
}