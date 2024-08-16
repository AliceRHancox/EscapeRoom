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
            components = new System.ComponentModel.Container();
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
            tmrTime = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1480, 975);
            btnBack.Margin = new Padding(6, 6, 6, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 49);
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
            lblNumber1.Location = new Point(1300, 149);
            lblNumber1.Margin = new Padding(4, 0, 4, 0);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(71, 59);
            lblNumber1.TabIndex = 2;
            lblNumber1.Text = "21";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber2.ForeColor = Color.White;
            lblNumber2.Location = new Point(1300, 367);
            lblNumber2.Margin = new Padding(4, 0, 4, 0);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(71, 59);
            lblNumber2.TabIndex = 3;
            lblNumber2.Text = "23";
            // 
            // lblNumber3
            // 
            lblNumber3.AutoSize = true;
            lblNumber3.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber3.ForeColor = Color.White;
            lblNumber3.Location = new Point(1300, 591);
            lblNumber3.Margin = new Padding(4, 0, 4, 0);
            lblNumber3.Name = "lblNumber3";
            lblNumber3.Size = new Size(71, 59);
            lblNumber3.TabIndex = 4;
            lblNumber3.Text = "21";
            // 
            // lblNumber4
            // 
            lblNumber4.AutoSize = true;
            lblNumber4.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber4.ForeColor = Color.White;
            lblNumber4.Location = new Point(1300, 815);
            lblNumber4.Margin = new Padding(4, 0, 4, 0);
            lblNumber4.Name = "lblNumber4";
            lblNumber4.Size = new Size(71, 59);
            lblNumber4.TabIndex = 5;
            lblNumber4.Text = "33";
            // 
            // lblNumber5
            // 
            lblNumber5.AutoSize = true;
            lblNumber5.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber5.ForeColor = Color.White;
            lblNumber5.Location = new Point(1111, 1007);
            lblNumber5.Margin = new Padding(4, 0, 4, 0);
            lblNumber5.Name = "lblNumber5";
            lblNumber5.Size = new Size(71, 59);
            lblNumber5.TabIndex = 6;
            lblNumber5.Text = "28";
            // 
            // lblNumber6
            // 
            lblNumber6.AutoSize = true;
            lblNumber6.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber6.ForeColor = Color.White;
            lblNumber6.Location = new Point(901, 1007);
            lblNumber6.Margin = new Padding(4, 0, 4, 0);
            lblNumber6.Name = "lblNumber6";
            lblNumber6.Size = new Size(71, 59);
            lblNumber6.TabIndex = 7;
            lblNumber6.Text = "23";
            // 
            // lblNumber7
            // 
            lblNumber7.AutoSize = true;
            lblNumber7.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber7.ForeColor = Color.White;
            lblNumber7.Location = new Point(680, 1007);
            lblNumber7.Margin = new Padding(4, 0, 4, 0);
            lblNumber7.Name = "lblNumber7";
            lblNumber7.Size = new Size(71, 59);
            lblNumber7.TabIndex = 8;
            lblNumber7.Text = "19";
            // 
            // lblNumber8
            // 
            lblNumber8.AutoSize = true;
            lblNumber8.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber8.ForeColor = Color.White;
            lblNumber8.Location = new Point(453, 1007);
            lblNumber8.Margin = new Padding(4, 0, 4, 0);
            lblNumber8.Name = "lblNumber8";
            lblNumber8.Size = new Size(71, 59);
            lblNumber8.TabIndex = 9;
            lblNumber8.Text = "28";
            // 
            // lblMissingNumber
            // 
            lblMissingNumber.AutoSize = true;
            lblMissingNumber.ForeColor = Color.White;
            lblMissingNumber.Location = new Point(32, 119);
            lblMissingNumber.Margin = new Padding(4, 0, 4, 0);
            lblMissingNumber.Name = "lblMissingNumber";
            lblMissingNumber.Size = new Size(196, 32);
            lblMissingNumber.TabIndex = 10;
            lblMissingNumber.Text = "Missing Number:";
            // 
            // txtBoxCode
            // 
            txtBoxCode.BackColor = Color.Black;
            txtBoxCode.ForeColor = Color.White;
            txtBoxCode.Location = new Point(32, 179);
            txtBoxCode.Margin = new Padding(4, 2, 4, 2);
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(238, 39);
            txtBoxCode.TabIndex = 11;
            // 
            // btnEntercode
            // 
            btnEntercode.BackColor = Color.Black;
            btnEntercode.BackgroundImageLayout = ImageLayout.None;
            btnEntercode.FlatStyle = FlatStyle.Popup;
            btnEntercode.ForeColor = Color.White;
            btnEntercode.Location = new Point(32, 256);
            btnEntercode.Margin = new Padding(4, 2, 4, 2);
            btnEntercode.Name = "btnEntercode";
            btnEntercode.Size = new Size(150, 47);
            btnEntercode.TabIndex = 12;
            btnEntercode.Text = "Enter";
            btnEntercode.UseVisualStyleBackColor = false;
            btnEntercode.Click += btnEnter_Click;
            // 
            // lblFeedBack
            // 
            lblFeedBack.ForeColor = Color.White;
            lblFeedBack.Location = new Point(32, 367);
            lblFeedBack.Margin = new Padding(4, 0, 4, 0);
            lblFeedBack.Name = "lblFeedBack";
            lblFeedBack.Size = new Size(269, 134);
            lblFeedBack.TabIndex = 13;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(1437, 36);
            btnEnd.Margin = new Padding(4, 2, 4, 2);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(182, 47);
            btnEnd.TabIndex = 14;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // tmrTime
            // 
            tmrTime.Interval = 1000;
            // 
            // frmPaintingPuzzle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Paintinglayout_2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1642, 1090);
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
            Margin = new Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Timer tmrTime;
    }
}