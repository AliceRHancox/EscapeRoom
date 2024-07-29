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
    public partial class frmPaintingPuzzle : Form
    {
        int CompletedPuzzles;
        
        public frmPaintingPuzzle(int argsCompletedPuzzles)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWest frmWest = new frmWest(CompletedPuzzles);
            frmWest.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmPaintingPuzzle_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            const int PAINT_CODE = 10;
            try
            {
                int EnteredCode = Convert.ToInt32(txtBoxCode.Text);
                if (EnteredCode == PAINT_CODE)
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
