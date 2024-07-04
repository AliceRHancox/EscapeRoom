namespace EscapeRoom
{
    partial class FrmSouth
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
            button1 = new Button();
            button2 = new Button();
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
            // 
            // picBookShelf
            // 
            picBookShelf.BackColor = Color.Transparent;
            picBookShelf.Location = new Point(280, 407);
            picBookShelf.Margin = new Padding(6);
            picBookShelf.Name = "picBookShelf";
            picBookShelf.Size = new Size(1077, 533);
            picBookShelf.TabIndex = 3;
            picBookShelf.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(585, 247);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1129, 174);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmSouth
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RoomLayout1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 1090);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(picBookShelf);
            Controls.Add(btnWest);
            Controls.Add(btnEast);
            DoubleBuffered = true;
            Margin = new Padding(6);
            Name = "FrmSouth";
            Text = "FrmSouth";
            ((System.ComponentModel.ISupportInitialize)picBookShelf).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEast;
        private Button btnWest;
        private PictureBox picBookShelf;
        private Button button1;
        private Button button2;
    }
}