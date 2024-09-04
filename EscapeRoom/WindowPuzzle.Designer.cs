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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWindowPuzzle));
            btnBack = new Button();
            lblRiddle = new Label();
            lblEntercode = new Label();
            txtBoxCode = new TextBox();
            btnEnter = new Button();
            lblFeedBack = new Label();
            btnEnd = new Button();
            tmrTime = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            lblRiddle.Font = new Font("Palatino Linotype", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRiddle.ForeColor = Color.White;
            lblRiddle.Location = new Point(111, 17);
            lblRiddle.Margin = new Padding(4, 0, 4, 0);
            lblRiddle.Name = "lblRiddle";
            lblRiddle.Size = new Size(838, 79);
            lblRiddle.TabIndex = 2;
            lblRiddle.Text = "First came the stars, Then came the moon, Then all the little fish in the sea.\r\nThe sheep smiled and grazed in the dark, as the trees grew old and worn.\r\n\r\n";
            // 
            // lblEntercode
            // 
            lblEntercode.AutoSize = true;
            lblEntercode.BackColor = Color.Transparent;
            lblEntercode.ForeColor = Color.White;
            lblEntercode.Location = new Point(121, 1009);
            lblEntercode.Margin = new Padding(4, 0, 4, 0);
            lblEntercode.Name = "lblEntercode";
            lblEntercode.Size = new Size(232, 32);
            lblEntercode.TabIndex = 3;
            lblEntercode.Text = "Enter Number Code:";
            // 
            // txtBoxCode
            // 
            txtBoxCode.BackColor = Color.Black;
            txtBoxCode.ForeColor = Color.White;
            txtBoxCode.Location = new Point(376, 1009);
            txtBoxCode.Margin = new Padding(4, 2, 4, 2);
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(414, 39);
            txtBoxCode.TabIndex = 4;
            txtBoxCode.Click += txtBoxCode_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Black;
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(827, 1009);
            btnEnter.Margin = new Padding(4, 2, 4, 2);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(150, 47);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblFeedBack
            // 
            lblFeedBack.AutoSize = true;
            lblFeedBack.BackColor = Color.Black;
            lblFeedBack.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeedBack.ForeColor = Color.White;
            lblFeedBack.Location = new Point(1003, 1009);
            lblFeedBack.Margin = new Padding(4, 0, 4, 0);
            lblFeedBack.Name = "lblFeedBack";
            lblFeedBack.Size = new Size(0, 32);
            lblFeedBack.TabIndex = 6;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(1437, 17);
            btnEnd.Margin = new Padding(4, 2, 4, 2);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(182, 47);
            btnEnd.TabIndex = 7;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // tmrTime
            // 
            tmrTime.Enabled = true;
            tmrTime.Tick += tmrTime_Tick;
            // 
            // frmWindowPuzzle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 1090);
            Controls.Add(btnEnd);
            Controls.Add(lblFeedBack);
            Controls.Add(btnEnter);
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
        private Button btnEnter;
        private Label lblFeedBack;
        private Button btnEnd;
        private System.Windows.Forms.Timer tmrTime;
    }
}