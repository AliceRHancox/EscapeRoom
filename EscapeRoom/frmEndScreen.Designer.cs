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
            btnMainMenu = new Button();
            SuspendLayout();
            // 
            // lblEndInfo
            // 
            lblEndInfo.Font = new Font("Palatino Linotype", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndInfo.ForeColor = Color.White;
            lblEndInfo.ImageAlign = ContentAlignment.MiddleRight;
            lblEndInfo.Location = new Point(74, 79);
            lblEndInfo.Margin = new Padding(4, 0, 4, 0);
            lblEndInfo.Name = "lblEndInfo";
            lblEndInfo.Size = new Size(1502, 113);
            lblEndInfo.TabIndex = 0;
            lblEndInfo.Text = "Congratulations! You have escaped the room. ";
            lblEndInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Palatino Linotype", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(635, 222);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(357, 64);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Your time is:";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShowTime
            // 
            lblShowTime.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShowTime.ForeColor = Color.White;
            lblShowTime.Location = new Point(492, 365);
            lblShowTime.Margin = new Padding(4, 0, 4, 0);
            lblShowTime.Name = "lblShowTime";
            lblShowTime.Size = new Size(654, 173);
            lblShowTime.TabIndex = 2;
            lblShowTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Black;
            btnMainMenu.BackgroundImageLayout = ImageLayout.None;
            btnMainMenu.FlatStyle = FlatStyle.Popup;
            btnMainMenu.Font = new Font("Palatino Linotype", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMainMenu.ForeColor = Color.White;
            btnMainMenu.Location = new Point(635, 729);
            btnMainMenu.Margin = new Padding(4, 2, 4, 2);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(362, 252);
            btnMainMenu.TabIndex = 6;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // frmEndScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1642, 1090);
            Controls.Add(btnMainMenu);
            Controls.Add(lblShowTime);
            Controls.Add(lblInfo);
            Controls.Add(lblEndInfo);
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmEndScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEndScreen";
            Load += frmEndScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblEndInfo;
        private Label lblInfo;
        private Label lblShowTime;
        private Button btnMainMenu;
    }
}