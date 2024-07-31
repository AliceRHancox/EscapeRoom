namespace EscapeRoom
{
    partial class frmLeaderBoard
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
            btnEnd = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1401, 973);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 59);
            btnBack.TabIndex = 0;
            btnBack.Text = "Main Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(1439, 29);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(182, 46);
            btnEnd.TabIndex = 8;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // frmLeaderBoard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1642, 1090);
            Controls.Add(btnEnd);
            Controls.Add(btnBack);
            Name = "frmLeaderBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLeaderBoard";
            Load += frmLeaderBoard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnEnd;
    }
}