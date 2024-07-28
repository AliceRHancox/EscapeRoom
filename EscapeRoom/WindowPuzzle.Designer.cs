namespace EscapeRoom
{
    partial class frmWindowPuzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWindowPuzzle));
            btnBack = new Button();
            lblRiddle = new Label();
            lblEntercode = new Label();
            txtBoxCode = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1480, 992);
            btnBack.Margin = new Padding(6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 49);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblRiddle
            // 
            lblRiddle.BackColor = Color.Transparent;
            lblRiddle.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRiddle.ForeColor = Color.White;
            lblRiddle.Location = new Point(112, 18);
            lblRiddle.Name = "lblRiddle";
            lblRiddle.Size = new Size(837, 78);
            lblRiddle.TabIndex = 2;
            lblRiddle.Text = "First came the stars, Then came the moon, Then all the little fish in the sea.\r\nThe sheep smiled and grazed in the dark, as the trees grew old and worn.\r\n\r\n";
            // 
            // lblEntercode
            // 
            lblEntercode.AutoSize = true;
            lblEntercode.BackColor = Color.Transparent;
            lblEntercode.ForeColor = Color.White;
            lblEntercode.Location = new Point(121, 1009);
            lblEntercode.Name = "lblEntercode";
            lblEntercode.Size = new Size(137, 32);
            lblEntercode.TabIndex = 3;
            lblEntercode.Text = "Enter Code:";
            // 
            // txtBoxCode
            // 
            txtBoxCode.BackColor = Color.Black;
            txtBoxCode.ForeColor = Color.White;
            txtBoxCode.Location = new Point(264, 1009);
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(414, 39);
            txtBoxCode.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(712, 1009);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmWindowPuzzle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 1090);
            Controls.Add(button1);
            Controls.Add(txtBoxCode);
            Controls.Add(lblEntercode);
            Controls.Add(lblRiddle);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            Margin = new Padding(6);
            Name = "frmWindowPuzzle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WindowPuzzle";
            Load += frmWindowPuzzle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblRiddle;
        private Label lblEntercode;
        private TextBox txtBoxCode;
        private Button button1;
    }
}