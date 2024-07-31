namespace EscapeRoom
{
    partial class frmEndScreen
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
            lblEndInfo = new Label();
            lblInfo = new Label();
            lblShowTime = new Label();
            lblPlease = new Label();
            txtBoxName = new TextBox();
            btnEnter = new Button();
            btnMainMenu = new Button();
            btnLeaderBoard = new Button();
            SuspendLayout();
            // 
            // lblEndInfo
            // 
            lblEndInfo.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndInfo.ForeColor = Color.White;
            lblEndInfo.ImageAlign = ContentAlignment.MiddleRight;
            lblEndInfo.Location = new Point(74, 79);
            lblEndInfo.Name = "lblEndInfo";
            lblEndInfo.Size = new Size(1503, 113);
            lblEndInfo.TabIndex = 0;
            lblEndInfo.Text = "Congratulations! You have escaped the room. ";
            lblEndInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(635, 221);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(356, 64);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Your time is:";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShowTime
            // 
            lblShowTime.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowTime.ForeColor = Color.White;
            lblShowTime.Location = new Point(449, 368);
            lblShowTime.Name = "lblShowTime";
            lblShowTime.Size = new Size(725, 258);
            lblShowTime.TabIndex = 2;
            lblShowTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlease
            // 
            lblPlease.AutoSize = true;
            lblPlease.ForeColor = Color.White;
            lblPlease.Location = new Point(96, 854);
            lblPlease.Name = "lblPlease";
            lblPlease.Size = new Size(492, 32);
            lblPlease.TabIndex = 3;
            lblPlease.Text = "Please enter your name for the leader board:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(96, 915);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(492, 39);
            txtBoxName.TabIndex = 4;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Black;
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(622, 915);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(150, 46);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Black;
            btnMainMenu.BackgroundImageLayout = ImageLayout.None;
            btnMainMenu.FlatStyle = FlatStyle.Popup;
            btnMainMenu.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.ForeColor = Color.White;
            btnMainMenu.Location = new Point(1019, 880);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(208, 117);
            btnMainMenu.TabIndex = 6;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnLeaderBoard
            // 
            btnLeaderBoard.BackColor = Color.Black;
            btnLeaderBoard.BackgroundImageLayout = ImageLayout.None;
            btnLeaderBoard.FlatStyle = FlatStyle.Popup;
            btnLeaderBoard.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLeaderBoard.ForeColor = Color.White;
            btnLeaderBoard.Location = new Point(1249, 880);
            btnLeaderBoard.Name = "btnLeaderBoard";
            btnLeaderBoard.Size = new Size(230, 117);
            btnLeaderBoard.TabIndex = 7;
            btnLeaderBoard.Text = "Leader Board";
            btnLeaderBoard.UseVisualStyleBackColor = false;
            btnLeaderBoard.Click += btnLeaderBoard_Click;
            // 
            // frmEndScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1642, 1090);
            Controls.Add(btnLeaderBoard);
            Controls.Add(btnMainMenu);
            Controls.Add(btnEnter);
            Controls.Add(txtBoxName);
            Controls.Add(lblPlease);
            Controls.Add(lblShowTime);
            Controls.Add(lblInfo);
            Controls.Add(lblEndInfo);
            Name = "frmEndScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEndScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEndInfo;
        private Label lblInfo;
        private Label lblShowTime;
        private Label lblPlease;
        private TextBox txtBoxName;
        private Button btnEnter;
        private Button btnMainMenu;
        private Button btnLeaderBoard;
    }
}