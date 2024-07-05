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
            btnEast.Location = new Point(15, 480);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(84, 33);
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
            btnWest.Location = new Point(790, 480);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(84, 33);
            btnWest.TabIndex = 2;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = false;
            btnWest.Click += btnWest_Click;
            // 
            // picBookShelf
            // 
            picBookShelf.BackColor = Color.Transparent;
            picBookShelf.Image = Properties.Resources.Bookshelf_layout_1;
            picBookShelf.Location = new Point(152, 197);
            picBookShelf.Name = "picBookShelf";
            picBookShelf.Size = new Size(580, 250);
            picBookShelf.TabIndex = 3;
            picBookShelf.TabStop = false;
            picBookShelf.Click += picBookShelf_Click;
            // 
            // frmSouth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RoomLayout1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 511);
            Controls.Add(picBookShelf);
            Controls.Add(btnWest);
            Controls.Add(btnEast);
            DoubleBuffered = true;
            Name = "frmSouth";
            Text = "FrmSouth";
            ((System.ComponentModel.ISupportInitialize)picBookShelf).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEast;
        private Button btnWest;
        private PictureBox picBookShelf;
    }
}