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
    public partial class frmEast : Form
    {
        int CompletedPuzzles;
        List<Puzzles> allPuzzles;

        public frmEast(int argsCompletedPuzzles, List<Puzzles> argspuzzle)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
        }

        private void picWindow_Click(object sender, EventArgs e)
        {
            frmWindowPuzzle frmWindowPuzzle = new frmWindowPuzzle(CompletedPuzzles, allPuzzles);
            frmWindowPuzzle.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            frmNorth frmNorth = new frmNorth(CompletedPuzzles, allPuzzles);
            frmNorth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            frmSouth frmSouth = new frmSouth(CompletedPuzzles, allPuzzles);
            frmSouth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmEast_Load(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
