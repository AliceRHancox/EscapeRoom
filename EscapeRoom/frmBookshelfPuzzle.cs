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
    public partial class frmBookshelfPuzzle : Form
    {
        int CompletedPuzzles;
        List<Puzzles> allPuzzles;
        const string BOOK_CODE = "umbrella";
        public frmBookshelfPuzzle(int argsCompletedPuzzles, List<Puzzles> argspuzzle)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSouth frmSouth = new frmSouth(CompletedPuzzles, allPuzzles);
            frmSouth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmBookshelfPuzzle_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < allPuzzles.Count; i++)
            {
                if (BOOK_CODE == allPuzzles[i].PuzzleCode)
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

        private void btnEnter_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < allPuzzles.Count; i++)
            {
                if(BOOK_CODE == allPuzzles[i].PuzzleCode)
                {
                    
                    try
                    {
                        string EnteredCode = txtBoxCode.Text.ToLower();
                        if (EnteredCode == BOOK_CODE)
                        {
                            lblFeedBack.ForeColor = Color.Green;
                            lblFeedBack.Text = "Code accepted. Unlocking puzzle.";
                            allPuzzles[i].Complete = true;
                            txtBoxCode.Visible=false;
                            btnEnter.Visible = false;
                            lblEntercode.Visible = false;
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

        private void lblTest_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            
        }
    }
}
