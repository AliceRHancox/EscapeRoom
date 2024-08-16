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
    public partial class frmSouth : Form
    {
        int CompletedPuzzles;
        List<Puzzles> allPuzzles;
        int time;
        public frmSouth(int argsCompletedPuzzles, List<Puzzles> argspuzzle, int argstime)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
            time = argstime;
        }

        private void picBookShelf_Click(object sender, EventArgs e)
        {
            frmBookshelfPuzzle frmBookshelfPuzzle = new frmBookshelfPuzzle(CompletedPuzzles, allPuzzles);
            frmBookshelfPuzzle.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            frmEast frmEast = new frmEast(CompletedPuzzles, allPuzzles, time);
            frmEast.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            frmWest frmWest = new frmWest(CompletedPuzzles, allPuzzles, time);
            frmWest.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmSouth_Load(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
