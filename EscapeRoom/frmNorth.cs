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
    public partial class frmNorth : Form
    {
        int CompletedPuzzles;
        const int MAX_PUZZLES = 3;
        List<Puzzles> allPuzzles;
        public frmNorth(int argsCompletedPuzzles, List<Puzzles> argspuzzle)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
        }

        private void frmNorth_Load(object sender, EventArgs e)
        {
            lblProgress.Text = "Puzzles completed" + Environment.NewLine + CompletedPuzzles + "/" + MAX_PUZZLES;
        }

        private void picDoor_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            frmEast frmEast = new frmEast(CompletedPuzzles, allPuzzles);
            frmEast.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            frmWest frmWest = new frmWest(CompletedPuzzles, allPuzzles);
            frmWest.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }


        private void btnEnd_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
