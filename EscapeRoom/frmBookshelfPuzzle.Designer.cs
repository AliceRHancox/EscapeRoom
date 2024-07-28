namespace EscapeRoom
{
    partial class frmBookshelfPuzzle
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
            btnBack = new Button();
            lblEntercode = new Label();
            txtBoxCode = new TextBox();
            btnEnter = new Button();
            lblFeedBack = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1456, 979);
            btnBack.Margin = new Padding(6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 49);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblEntercode
            // 
            lblEntercode.AutoSize = true;
            lblEntercode.BackColor = Color.Black;
            lblEntercode.ForeColor = Color.White;
            lblEntercode.Location = new Point(12, 871);
            lblEntercode.Name = "lblEntercode";
            lblEntercode.Size = new Size(222, 32);
            lblEntercode.TabIndex = 1;
            lblEntercode.Text = "Enter Hidden Code:";
            // 
            // txtBoxCode
            // 
            txtBoxCode.BackColor = Color.Black;
            txtBoxCode.ForeColor = Color.White;
            txtBoxCode.Location = new Point(240, 871);
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(419, 39);
            txtBoxCode.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Black;
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(686, 864);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(150, 46);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblFeedBack
            // 
            lblFeedBack.AutoSize = true;
            lblFeedBack.BackColor = Color.Black;
            lblFeedBack.ForeColor = Color.White;
            lblFeedBack.Location = new Point(868, 874);
            lblFeedBack.Name = "lblFeedBack";
            lblFeedBack.Size = new Size(0, 32);
            lblFeedBack.TabIndex = 4;
            // 
            // frmBookshelfPuzzle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BooksfromBookshelf_layout_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 1090);
            Controls.Add(lblFeedBack);
            Controls.Add(btnEnter);
            Controls.Add(txtBoxCode);
            Controls.Add(lblEntercode);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            Margin = new Padding(6);
            Name = "frmBookshelfPuzzle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookshelfPuzzle";
            Load += frmBookshelfPuzzle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblEntercode;
        private TextBox txtBoxCode;
        private Button btnEnter;
        private Label lblFeedBack;
    }
}