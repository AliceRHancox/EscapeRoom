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
            lblWrong = new Label();
            SuspendLayout();
            // 
            // lblEndInfo
            // 
            lblEndInfo.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndInfo.ForeColor = Color.White;
            lblEndInfo.ImageAlign = ContentAlignment.MiddleRight;
            lblEndInfo.Location = new Point(40, 37);
            lblEndInfo.Margin = new Padding(2, 0, 2, 0);
            lblEndInfo.Name = "lblEndInfo";
            lblEndInfo.Size = new Size(809, 53);
            lblEndInfo.TabIndex = 0;
            lblEndInfo.Text = "Congratulations! You have escaped the room. ";
            lblEndInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(342, 104);
            lblInfo.Margin = new Padding(2, 0, 2, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(192, 30);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Your time is:";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShowTime
            // 
            lblShowTime.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowTime.ForeColor = Color.White;
            lblShowTime.Location = new Point(265, 171);
            lblShowTime.Margin = new Padding(2, 0, 2, 0);
            lblShowTime.Name = "lblShowTime";
            lblShowTime.Size = new Size(352, 81);
            lblShowTime.TabIndex = 2;
            lblShowTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlease
            // 
            lblPlease.AutoSize = true;
            lblPlease.ForeColor = Color.White;
            lblPlease.Location = new Point(52, 400);
            lblPlease.Margin = new Padding(2, 0, 2, 0);
            lblPlease.Name = "lblPlease";
            lblPlease.Size = new Size(240, 15);
            lblPlease.TabIndex = 3;
            lblPlease.Text = "Please enter your name for the leader board:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(52, 429);
            txtBoxName.Margin = new Padding(2, 1, 2, 1);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(313, 23);
            txtBoxName.TabIndex = 4;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Black;
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(393, 423);
            btnEnter.Margin = new Padding(2, 1, 2, 1);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(105, 29);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Confirm Name";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Black;
            btnMainMenu.BackgroundImageLayout = ImageLayout.None;
            btnMainMenu.FlatStyle = FlatStyle.Popup;
            btnMainMenu.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.ForeColor = Color.White;
            btnMainMenu.Location = new Point(99, 276);
            btnMainMenu.Margin = new Padding(2, 1, 2, 1);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(195, 118);
            btnMainMenu.TabIndex = 6;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Visible = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnLeaderBoard
            // 
            btnLeaderBoard.BackColor = Color.Black;
            btnLeaderBoard.BackgroundImageLayout = ImageLayout.None;
            btnLeaderBoard.FlatStyle = FlatStyle.Popup;
            btnLeaderBoard.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLeaderBoard.ForeColor = Color.White;
            btnLeaderBoard.Location = new Point(561, 276);
            btnLeaderBoard.Margin = new Padding(2, 1, 2, 1);
            btnLeaderBoard.Name = "btnLeaderBoard";
            btnLeaderBoard.Size = new Size(187, 118);
            btnLeaderBoard.TabIndex = 7;
            btnLeaderBoard.Text = "Leader Board";
            btnLeaderBoard.UseVisualStyleBackColor = false;
            btnLeaderBoard.Visible = false;
            btnLeaderBoard.Click += btnLeaderBoard_Click;
            // 
            // lblWrong
            // 
            lblWrong.AutoSize = true;
            lblWrong.ForeColor = Color.White;
            lblWrong.Location = new Point(52, 467);
            lblWrong.Margin = new Padding(2, 0, 2, 0);
            lblWrong.Name = "lblWrong";
            lblWrong.Size = new Size(0, 15);
            lblWrong.TabIndex = 8;
            // 
            // frmEndScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(884, 511);
            Controls.Add(lblWrong);
            Controls.Add(btnLeaderBoard);
            Controls.Add(btnMainMenu);
            Controls.Add(btnEnter);
            Controls.Add(txtBoxName);
            Controls.Add(lblPlease);
            Controls.Add(lblShowTime);
            Controls.Add(lblInfo);
            Controls.Add(lblEndInfo);
            Margin = new Padding(2, 1, 2, 1);
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
        private Label lblWrong;
    }
}