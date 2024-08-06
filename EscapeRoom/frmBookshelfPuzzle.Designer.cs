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
            btnEnd = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(784, 459);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
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
            lblEntercode.Location = new Point(6, 408);
            lblEntercode.Margin = new Padding(2, 0, 2, 0);
            lblEntercode.Name = "lblEntercode";
            lblEntercode.Size = new Size(110, 15);
            lblEntercode.TabIndex = 1;
            lblEntercode.Text = "Enter Hidden Code:";
            // 
            // txtBoxCode
            // 
            txtBoxCode.BackColor = Color.Black;
            txtBoxCode.ForeColor = Color.White;
            txtBoxCode.Location = new Point(129, 408);
            txtBoxCode.Margin = new Padding(2, 1, 2, 1);
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(227, 23);
            txtBoxCode.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Black;
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(369, 405);
            btnEnter.Margin = new Padding(2, 1, 2, 1);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(81, 22);
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
            lblFeedBack.Location = new Point(467, 410);
            lblFeedBack.Margin = new Padding(2, 0, 2, 0);
            lblFeedBack.Name = "lblFeedBack";
            lblFeedBack.Size = new Size(0, 15);
            lblFeedBack.TabIndex = 4;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(761, 6);
            btnEnd.Margin = new Padding(2, 1, 2, 1);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(98, 22);
            btnEnd.TabIndex = 8;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(71, 126);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 232);
            label1.TabIndex = 9;
            label1.Paint += lblTest_Paint;
            // 
            // frmBookshelfPuzzle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BooksfromBookshelf_layout_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 511);
            Controls.Add(label1);
            Controls.Add(btnEnd);
            Controls.Add(lblFeedBack);
            Controls.Add(btnEnter);
            Controls.Add(txtBoxCode);
            Controls.Add(lblEntercode);
            Controls.Add(btnBack);
            DoubleBuffered = true;
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
        private Button btnEnd;
        private Label label1;
    }
}