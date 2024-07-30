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
        List<Puzzles> allPuzzles;
        const int PAINT_CODE = 10;
        public frmPaintingPuzzle(int argsCompletedPuzzles, List<Puzzles> argspuzzle)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWest frmWest = new frmWest(CompletedPuzzles, allPuzzles);
            frmWest.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmPaintingPuzzle_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < allPuzzles.Count; i++)
            {
                if (Convert.ToString(PAINT_CODE) == allPuzzles[i].PuzzleCode)
                {
                    if (allPuzzles[i].Complete == true)
                    {
                        lblFeedBack.ForeColor = Color.Green;
                        lblFeedBack.Text = "Puzzle already unlocked";
                        txtBoxCode.Visible = false;
                        btnEntercode.Visible = false;
                        lblMissingNumber.Visible = false;
                    }
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allPuzzles.Count; i++)
            {
                if (Convert.ToString(PAINT_CODE) == allPuzzles[i].PuzzleCode)
                {
                    try
                    {
                        int EnteredCode = Convert.ToInt32(txtBoxCode.Text);
                        if (EnteredCode == PAINT_CODE)
                        {
                            lblFeedBack.ForeColor = Color.Green;
                            lblFeedBack.Text = "Code accepted. Unlocking puzzle.";
                            allPuzzles[i].Complete = true;
                            txtBoxCode.Visible = false;
                            btnEntercode.Visible = false;
                            lblMissingNumber.Visible = false;

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

        private void btnEnd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
