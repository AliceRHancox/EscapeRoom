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
        List<Puzzles> allPuzzles;
        const int WINDOW_CODE = 301489;
        public frmWindowPuzzle(int argsCompletedPuzzles, List<Puzzles> argspuzzle)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
        }

        private void frmWindowPuzzle_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < allPuzzles.Count; i++)
            {
                if (Convert.ToString(WINDOW_CODE) == allPuzzles[i].PuzzleCode)
                {
                    if (allPuzzles[i].Complete == true)
                    {
                        lblFeedBack.ForeColor = Color.Green;
                        lblFeedBack.Text = "Puzzle already unlocked";
                        txtBoxCode.Visible = false;
                        btnEnter.Visible = false;
                        lblEntercode.Visible = false;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEast frmEast = new frmEast(CompletedPuzzles, allPuzzles);
            frmEast.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allPuzzles.Count; i++)
            {
                if (Convert.ToString(WINDOW_CODE) == allPuzzles[i].PuzzleCode)
                {
                    try
                    {
                        int EnteredCode = Convert.ToInt32(txtBoxCode.Text);
                        if (EnteredCode == WINDOW_CODE)
                        {
                            lblFeedBack.ForeColor = Color.Green;
                            lblFeedBack.Text = "Code accepted. Unlocking puzzle.";
                            allPuzzles[i].Complete = true;
                            txtBoxCode.Visible = false;
                            btnEnter.Visible = false;
                            lblEntercode.Visible = false;
                            CompletedPuzzles = CompletedPuzzles + 1;
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
