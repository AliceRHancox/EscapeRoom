namespace EscapeRoom
{
    partial class frmPaintingPuzzle
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
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            lblNumber3 = new Label();
            lblNumber4 = new Label();
            lblNumber5 = new Label();
            lblNumber6 = new Label();
            lblNumber7 = new Label();
            lblNumber8 = new Label();
            lblMissingNumber = new Label();
            txtBoxCode = new TextBox();
            btnEntercode = new Button();
            lblFeedBack = new Label();
            btnEnd = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(797, 457);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber1.ForeColor = Color.White;
            lblNumber1.Location = new Point(700, 70);
            lblNumber1.Margin = new Padding(2, 0, 2, 0);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(37, 30);
            lblNumber1.TabIndex = 2;
            lblNumber1.Text = "21";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber2.ForeColor = Color.White;
            lblNumber2.Location = new Point(700, 172);
            lblNumber2.Margin = new Padding(2, 0, 2, 0);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(37, 30);
            lblNumber2.TabIndex = 3;
            lblNumber2.Text = "23";
            // 
            // lblNumber3
            // 
            lblNumber3.AutoSize = true;
            lblNumber3.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber3.ForeColor = Color.White;
            lblNumber3.Location = new Point(700, 277);
            lblNumber3.Margin = new Padding(2, 0, 2, 0);
            lblNumber3.Name = "lblNumber3";
            lblNumber3.Size = new Size(37, 30);
            lblNumber3.TabIndex = 4;
            lblNumber3.Text = "21";
            // 
            // lblNumber4
            // 
            lblNumber4.AutoSize = true;
            lblNumber4.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber4.ForeColor = Color.White;
            lblNumber4.Location = new Point(700, 382);
            lblNumber4.Margin = new Padding(2, 0, 2, 0);
            lblNumber4.Name = "lblNumber4";
            lblNumber4.Size = new Size(37, 30);
            lblNumber4.TabIndex = 5;
            lblNumber4.Text = "33";
            // 
            // lblNumber5
            // 
            lblNumber5.AutoSize = true;
            lblNumber5.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber5.ForeColor = Color.White;
            lblNumber5.Location = new Point(598, 472);
            lblNumber5.Margin = new Padding(2, 0, 2, 0);
            lblNumber5.Name = "lblNumber5";
            lblNumber5.Size = new Size(37, 30);
            lblNumber5.TabIndex = 6;
            lblNumber5.Text = "28";
            // 
            // lblNumber6
            // 
            lblNumber6.AutoSize = true;
            lblNumber6.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber6.ForeColor = Color.White;
            lblNumber6.Location = new Point(485, 472);
            lblNumber6.Margin = new Padding(2, 0, 2, 0);
            lblNumber6.Name = "lblNumber6";
            lblNumber6.Size = new Size(37, 30);
            lblNumber6.TabIndex = 7;
            lblNumber6.Text = "23";
            // 
            // lblNumber7
            // 
            lblNumber7.AutoSize = true;
            lblNumber7.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber7.ForeColor = Color.White;
            lblNumber7.Location = new Point(366, 472);
            lblNumber7.Margin = new Padding(2, 0, 2, 0);
            lblNumber7.Name = "lblNumber7";
            lblNumber7.Size = new Size(37, 30);
            lblNumber7.TabIndex = 8;
            lblNumber7.Text = "19";
            // 
            // lblNumber8
            // 
            lblNumber8.AutoSize = true;
            lblNumber8.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber8.ForeColor = Color.White;
            lblNumber8.Location = new Point(244, 472);
            lblNumber8.Margin = new Padding(2, 0, 2, 0);
            lblNumber8.Name = "lblNumber8";
            lblNumber8.Size = new Size(37, 30);
            lblNumber8.TabIndex = 9;
            lblNumber8.Text = "28";
            // 
            // lblMissingNumber
            // 
            lblMissingNumber.AutoSize = true;
            lblMissingNumber.ForeColor = Color.White;
            lblMissingNumber.Location = new Point(17, 56);
            lblMissingNumber.Margin = new Padding(2, 0, 2, 0);
            lblMissingNumber.Name = "lblMissingNumber";
            lblMissingNumber.Size = new Size(98, 15);
            lblMissingNumber.TabIndex = 10;
            lblMissingNumber.Text = "Missing Number:";
            // 
            // txtBoxCode
            // 
            txtBoxCode.BackColor = Color.Black;
            txtBoxCode.ForeColor = Color.White;
            txtBoxCode.Location = new Point(17, 84);
            txtBoxCode.Margin = new Padding(2, 1, 2, 1);
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(130, 23);
            txtBoxCode.TabIndex = 11;
            // 
            // btnEntercode
            // 
            btnEntercode.BackColor = Color.Black;
            btnEntercode.BackgroundImageLayout = ImageLayout.None;
            btnEntercode.FlatStyle = FlatStyle.Popup;
            btnEntercode.ForeColor = Color.White;
            btnEntercode.Location = new Point(17, 120);
            btnEntercode.Margin = new Padding(2, 1, 2, 1);
            btnEntercode.Name = "btnEntercode";
            btnEntercode.Size = new Size(81, 22);
            btnEntercode.TabIndex = 12;
            btnEntercode.Text = "Enter";
            btnEntercode.UseVisualStyleBackColor = false;
            btnEntercode.Click += btnEnter_Click;
            // 
            // lblFeedBack
            // 
            lblFeedBack.ForeColor = Color.White;
            lblFeedBack.Location = new Point(17, 172);
            lblFeedBack.Margin = new Padding(2, 0, 2, 0);
            lblFeedBack.Name = "lblFeedBack";
            lblFeedBack.Size = new Size(145, 63);
            lblFeedBack.TabIndex = 13;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(774, 17);
            btnEnd.Margin = new Padding(2, 1, 2, 1);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(98, 22);
            btnEnd.TabIndex = 14;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // frmPaintingPuzzle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Paintinglayout_2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(884, 511);
            Controls.Add(btnEnd);
            Controls.Add(lblFeedBack);
            Controls.Add(btnEntercode);
            Controls.Add(txtBoxCode);
            Controls.Add(lblMissingNumber);
            Controls.Add(lblNumber8);
            Controls.Add(lblNumber7);
            Controls.Add(lblNumber6);
            Controls.Add(lblNumber5);
            Controls.Add(lblNumber4);
            Controls.Add(lblNumber3);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            Name = "frmPaintingPuzzle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaintingPuzzle";
            Load += frmPaintingPuzzle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblNumber1;
        private Label lblNumber2;
        private Label lblNumber3;
        private Label lblNumber4;
        private Label lblNumber5;
        private Label lblNumber6;
        private Label lblNumber7;
        private Label lblNumber8;
        private Label lblMissingNumber;
        private TextBox txtBoxCode;
        private Button btnEntercode;
        private Label lblFeedBack;
        private Button btnEnd;
    }
}