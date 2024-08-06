namespace EscapeRoom
{
    partial class frmEast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEast));
            btnNorth = new Button();
            btnSouth = new Button();
            picWindow = new PictureBox();
            btnEnd = new Button();
            ((System.ComponentModel.ISupportInitialize)picWindow).BeginInit();
            SuspendLayout();
            // 
            // btnNorth
            // 
            btnNorth.BackColor = Color.Transparent;
            btnNorth.FlatStyle = FlatStyle.Popup;
            btnNorth.ForeColor = Color.White;
            btnNorth.Location = new Point(15, 480);
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
            btnSouth.Location = new Point(790, 480);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(84, 33);
            btnSouth.TabIndex = 2;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = false;
            btnSouth.Click += btnSouth_Click;
            // 
            // picWindow
            // 
            picWindow.Image = (Image)resources.GetObject("picWindow.Image");
            picWindow.Location = new Point(213, 142);
            picWindow.Name = "picWindow";
            picWindow.Size = new Size(450, 230);
            picWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            picWindow.TabIndex = 3;
            picWindow.TabStop = false;
            picWindow.Click += picWindow_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(708, 6);
            btnEnd.Margin = new Padding(2, 1, 2, 1);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(98, 22);
            btnEnd.TabIndex = 8;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // frmEast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RoomLayout1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 511);
            Controls.Add(btnEnd);
            Controls.Add(picWindow);
            Controls.Add(btnSouth);
            Controls.Add(btnNorth);
            DoubleBuffered = true;
            Name = "frmEast";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEast";
            Load += frmEast_Load;
            ((System.ComponentModel.ISupportInitialize)picWindow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNorth;
        private Button btnSouth;
        private PictureBox picWindow;
        private Button btnEnd;
    }
}