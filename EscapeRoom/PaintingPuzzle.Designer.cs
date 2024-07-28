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
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1480, 975);
            btnBack.Margin = new Padding(6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 49);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmPaintingPuzzle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1642, 1090);
            Controls.Add(btnBack);
            Margin = new Padding(6);
            Name = "frmPaintingPuzzle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaintingPuzzle";
            Load += frmPaintingPuzzle_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
    }
}