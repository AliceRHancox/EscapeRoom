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
            btnLeaderBoard = new Button();
            btnEnd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(244, 45);
            label1.Name = "label1";
            label1.Size = new Size(426, 87);
            label1.TabIndex = 0;
            label1.Text = "Escape Room";
            // 
            // btnStart
            // 
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(350, 209);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(190, 64);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnLeaderBoard
            // 
            btnLeaderBoard.FlatStyle = FlatStyle.Popup;
            btnLeaderBoard.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeaderBoard.ForeColor = Color.White;
            btnLeaderBoard.Location = new Point(350, 279);
            btnLeaderBoard.Name = "btnLeaderBoard";
            btnLeaderBoard.Size = new Size(190, 64);
            btnLeaderBoard.TabIndex = 2;
            btnLeaderBoard.Text = "Leader Board";
            btnLeaderBoard.UseVisualStyleBackColor = true;
            btnLeaderBoard.Click += btnLeaderBoard_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.FlatStyle = FlatStyle.Popup;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(775, 11);
            btnEnd.Margin = new Padding(2, 1, 2, 1);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(98, 22);
            btnEnd.TabIndex = 8;
            btnEnd.Text = "Exit Program";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click_1;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(884, 511);
            Controls.Add(btnEnd);
            Controls.Add(btnLeaderBoard);
            Controls.Add(btnStart);
            Controls.Add(label1);
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
        private Button btnLeaderBoard;
        private Button btnEnd;
    }
}
