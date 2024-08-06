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
            btnEnter = new Button();
            lblFeedBack = new Label();
            btnEnd = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(797, 465);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
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
            lblRiddle.Location = new Point(60, 8);
            lblRiddle.Margin = new Padding(2, 0, 2, 0);
            lblRiddle.Name = "lblRiddle";
            lblRiddle.Size = new Size(451, 37);
            lblRiddle.TabIndex = 2;
            lblRiddle.Text = "First came the stars, Then came the moon, Then all the little fish in the sea.\r\nThe sheep smiled and grazed in the dark, as the trees grew old and worn.\r\n\r\n";
            // 
            // lblEntercode
            // 
            lblEntercode.AutoSize = true;
            lblEntercode.BackColor = Color.Transparent;
            lblEntercode.ForeColor = Color.White;
            lblEntercode.Location = new Point(65, 473);
            lblEntercode.Margin = new Padding(2, 0, 2, 0);
            lblEntercode.Name = "lblEntercode";
            lblEntercode.Size = new Size(68, 15);
            lblEntercode.TabIndex = 3;
            lblEntercode.Text = "Enter Code:";
            // 
            // txtBoxCode
            // 
            txtBoxCode.BackColor = Color.Black;
            txtBoxCode.ForeColor = Color.White;
            txtBoxCode.Location = new Point(142, 473);
            txtBoxCode.Margin = new Padding(2, 1, 2, 1);
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(225, 23);
            txtBoxCode.TabIndex = 4;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Black;
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(383, 473);
            btnEnter.Margin = new Padding(2, 1, 2, 1);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(81, 22);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblFeedBack
            // 
            lblFeedBack.AutoSize = true;
            lblFeedBack.BackColor = Color.Black;
            lblFeedBack.ForeColor = Color.White;
            lblFeedBack.Location = new Point(492, 473);
            lblFeedBack.Margin = new Padding(2, 0, 2, 0);
            lblFeedBack.Name = "lblFeedBack";
            lblFeedBack.Size = new Size(0, 15);
            lblFeedBack.TabIndex = 6;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(774, 8);
            btnEnd.Margin = new Padding(2, 1, 2, 1);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(98, 22);
            btnEnd.TabIndex = 7;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // frmWindowPuzzle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 511);
            Controls.Add(btnEnd);
            Controls.Add(lblFeedBack);
            Controls.Add(btnEnter);
            Controls.Add(txtBoxCode);
            Controls.Add(lblEntercode);
            Controls.Add(lblRiddle);
            Controls.Add(btnBack);
            DoubleBuffered = true;
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
    }
}