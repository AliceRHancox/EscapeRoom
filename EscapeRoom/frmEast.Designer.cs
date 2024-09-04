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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEast));
            btnNorth = new Button();
            btnSouth = new Button();
            picWindow = new PictureBox();
            btnEnd = new Button();
            tmrTime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picWindow).BeginInit();
            SuspendLayout();
            // 
            // btnNorth
            // 
            btnNorth.BackColor = Color.Transparent;
            btnNorth.FlatStyle = FlatStyle.Popup;
            btnNorth.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNorth.ForeColor = Color.White;
            btnNorth.Location = new Point(28, 1024);
            btnNorth.Margin = new Padding(6);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(156, 70);
            btnNorth.TabIndex = 1;
            btnNorth.Text = "North";
            btnNorth.UseVisualStyleBackColor = false;
            btnNorth.Click += btnNorth_Click;
            // 
            // btnSouth
            // 
            btnSouth.BackColor = Color.Transparent;
            btnSouth.FlatStyle = FlatStyle.Popup;
            btnSouth.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSouth.ForeColor = Color.White;
            btnSouth.Location = new Point(1467, 1024);
            btnSouth.Margin = new Padding(6);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(156, 70);
            btnSouth.TabIndex = 2;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = false;
            btnSouth.Click += btnSouth_Click;
            // 
            // picWindow
            // 
            picWindow.Image = (Image)resources.GetObject("picWindow.Image");
            picWindow.Location = new Point(396, 303);
            picWindow.Margin = new Padding(6);
            picWindow.Name = "picWindow";
            picWindow.Size = new Size(836, 491);
            picWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            picWindow.TabIndex = 3;
            picWindow.TabStop = false;
            picWindow.Click += picWindow_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(1315, 13);
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
            // frmEast
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RoomLayout1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 1090);
            Controls.Add(btnEnd);
            Controls.Add(picWindow);
            Controls.Add(btnSouth);
            Controls.Add(btnNorth);
            DoubleBuffered = true;
            Margin = new Padding(6);
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
        private System.Windows.Forms.Timer tmrTime;
    }
}