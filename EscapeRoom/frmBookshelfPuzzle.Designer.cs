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
            components = new System.ComponentModel.Container();
            btnBack = new Button();
            lblEntercode = new Label();
            txtBoxCode = new TextBox();
            btnEnter = new Button();
            lblFeedBack = new Label();
            btnEnd = new Button();
            lblBook1 = new Label();
            lblBook2 = new Label();
            lblBook3 = new Label();
            lblBook4 = new Label();
            lblBook5 = new Label();
            lblBook6 = new Label();
            lblBook7 = new Label();
            lblBook8 = new Label();
            tmrTime = new System.Windows.Forms.Timer(components);
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
            lblEntercode.Location = new Point(11, 870);
            lblEntercode.Margin = new Padding(4, 0, 4, 0);
            lblEntercode.Name = "lblEntercode";
            lblEntercode.Size = new Size(222, 32);
            lblEntercode.TabIndex = 1;
            lblEntercode.Text = "Enter Hidden Code:";
            // 
            // txtBoxCode
            // 
            txtBoxCode.BackColor = Color.Black;
            txtBoxCode.ForeColor = Color.White;
            txtBoxCode.Location = new Point(240, 870);
            txtBoxCode.Margin = new Padding(4, 2, 4, 2);
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(418, 39);
            txtBoxCode.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Black;
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(685, 864);
            btnEnter.Margin = new Padding(4, 2, 4, 2);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(150, 47);
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
            lblFeedBack.Location = new Point(867, 875);
            lblFeedBack.Margin = new Padding(4, 0, 4, 0);
            lblFeedBack.Name = "lblFeedBack";
            lblFeedBack.Size = new Size(0, 32);
            lblFeedBack.TabIndex = 4;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(1413, 13);
            btnEnd.Margin = new Padding(4, 2, 4, 2);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(182, 47);
            btnEnd.TabIndex = 8;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // lblBook1
            // 
            lblBook1.BackColor = Color.Transparent;
            lblBook1.Location = new Point(169, 226);
            lblBook1.Margin = new Padding(4, 0, 4, 0);
            lblBook1.Name = "lblBook1";
            lblBook1.Size = new Size(102, 574);
            lblBook1.TabIndex = 9;
            lblBook1.Paint += lbl_Paint;
            // 
            // lblBook2
            // 
            lblBook2.BackColor = Color.Transparent;
            lblBook2.Location = new Point(358, 226);
            lblBook2.Margin = new Padding(4, 0, 4, 0);
            lblBook2.Name = "lblBook2";
            lblBook2.Size = new Size(97, 557);
            lblBook2.TabIndex = 10;
            lblBook2.Paint += lbl_Paint;
            // 
            // lblBook3
            // 
            lblBook3.BackColor = Color.Transparent;
            lblBook3.Location = new Point(555, 226);
            lblBook3.Margin = new Padding(4, 0, 4, 0);
            lblBook3.Name = "lblBook3";
            lblBook3.Size = new Size(106, 557);
            lblBook3.TabIndex = 11;
            lblBook3.Paint += lbl_Paint;
            // 
            // lblBook4
            // 
            lblBook4.BackColor = Color.Transparent;
            lblBook4.Location = new Point(747, 226);
            lblBook4.Margin = new Padding(4, 0, 4, 0);
            lblBook4.Name = "lblBook4";
            lblBook4.Size = new Size(121, 557);
            lblBook4.TabIndex = 12;
            lblBook4.Paint += lbl_Paint;
            // 
            // lblBook5
            // 
            lblBook5.BackColor = Color.Transparent;
            lblBook5.Location = new Point(943, 226);
            lblBook5.Margin = new Padding(4, 0, 4, 0);
            lblBook5.Name = "lblBook5";
            lblBook5.Size = new Size(110, 557);
            lblBook5.TabIndex = 13;
            lblBook5.Paint += lbl_Paint;
            // 
            // lblBook6
            // 
            lblBook6.BackColor = Color.Transparent;
            lblBook6.Location = new Point(1137, 226);
            lblBook6.Margin = new Padding(4, 0, 4, 0);
            lblBook6.Name = "lblBook6";
            lblBook6.Size = new Size(113, 574);
            lblBook6.TabIndex = 14;
            lblBook6.Paint += lbl_Paint;
            // 
            // lblBook7
            // 
            lblBook7.BackColor = Color.Transparent;
            lblBook7.Location = new Point(1341, 226);
            lblBook7.Margin = new Padding(4, 0, 4, 0);
            lblBook7.Name = "lblBook7";
            lblBook7.Size = new Size(102, 557);
            lblBook7.TabIndex = 15;
            lblBook7.Paint += lbl_Paint;
            // 
            // lblBook8
            // 
            lblBook8.BackColor = Color.Transparent;
            lblBook8.Location = new Point(1528, 226);
            lblBook8.Margin = new Padding(4, 0, 4, 0);
            lblBook8.Name = "lblBook8";
            lblBook8.Size = new Size(113, 557);
            lblBook8.TabIndex = 16;
            lblBook8.Paint += lbl_Paint;
            // 
            // tmrTime
            // 
            tmrTime.Enabled = true;
            tmrTime.Interval = 550;
            tmrTime.Tick += tmrTime_Tick;
            // 
            // frmBookshelfPuzzle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BooksfromBookshelf_layout_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 1090);
            Controls.Add(lblBook8);
            Controls.Add(lblBook7);
            Controls.Add(lblBook6);
            Controls.Add(lblBook5);
            Controls.Add(lblBook4);
            Controls.Add(lblBook3);
            Controls.Add(lblBook2);
            Controls.Add(lblBook1);
            Controls.Add(btnEnd);
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
        private Button btnEnd;
        private Label lblBook1;
        private Label lblBook2;
        private Label lblBook3;
        private Label lblBook4;
        private Label lblBook5;
        private Label lblBook6;
        private Label lblBook7;
        private Label lblBook8;
        private System.Windows.Forms.Timer tmrTime;
    }
}