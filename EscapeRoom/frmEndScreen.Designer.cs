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
            lblEndInfo.Text = "Congratulations! You have escaped then room. ";
            lblEndInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(523, 252);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(156, 64);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Your time is";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmEndScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1642, 1090);
            Controls.Add(lblInfo);
            Controls.Add(lblEndInfo);
            Name = "frmEndScreen";
            Text = "frmEndScreen";
            ResumeLayout(false);
        }

        #endregion

        private Label lblEndInfo;
        private Label lblInfo;
    }
}