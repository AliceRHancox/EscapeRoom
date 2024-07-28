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
            label1 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 1015);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // frmWindowPuzzle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 1090);
            Controls.Add(label1);
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
        private Label label1;
    }
}