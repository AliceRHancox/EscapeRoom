namespace EscapeRoom
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
            btnEast = new Button();
            btnWest = new Button();
            picBookShelf = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBookShelf).BeginInit();
            SuspendLayout();
            // 
            // btnEast
            // 
            btnEast.BackColor = Color.Transparent;
            btnEast.FlatStyle = FlatStyle.Popup;
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
            picBookShelf.Size = new Size(1080, 530);
            picBookShelf.SizeMode = PictureBoxSizeMode.StretchImage;
            picBookShelf.TabIndex = 3;
            picBookShelf.TabStop = false;
            picBookShelf.Click += picBookShelf_Click;
            // 
            // frmSouth
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RoomLayout1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 1090);
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
    }
}