using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoom
{
    public partial class frmWindowPuzzle : Form
    {
        int CompletedPuzzles;
        
        public frmWindowPuzzle(int argsCompletedPuzzles)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
        }

        private void frmWindowPuzzle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEast frmEast = new frmEast(CompletedPuzzles);
            frmEast.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            const int WINDOW_CODE = 301489;
            try
            {
                int EnteredCode = Convert.ToInt32(txtBoxCode.Text);
                if(EnteredCode == WINDOW_CODE)
                {
                    lblFeedBack.ForeColor = Color.Green;
                    lblFeedBack.Text = "Code accepted. Unlocking puzzle.";
                    
                }
                else
                {
                    lblFeedBack.ForeColor = Color.Red;
                    lblFeedBack.Text = "Incorrect code";
                }
            }
            catch
            {
                lblFeedBack.ForeColor = Color.Red;
                lblFeedBack.Text = "Invalid input";
            }
        }
    }
}
