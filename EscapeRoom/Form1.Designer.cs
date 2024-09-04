namespace EscapeRoom
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnStart = new Button();
            btnEnd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(453, 96);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(849, 172);
            label1.TabIndex = 0;
            label1.Text = "Escape Room";
            // 
            // btnStart
            // 
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(675, 534);
            btnStart.Margin = new Padding(6);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(353, 137);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(1439, 23);
            btnEnd.Margin = new Padding(4, 2, 4, 2);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(182, 47);
            btnEnd.TabIndex = 8;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click_1;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1642, 1060);
            Controls.Add(btnEnd);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmMainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStart;
        private Button btnEnd;
    }
}
