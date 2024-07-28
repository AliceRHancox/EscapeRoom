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
    public partial class frmWest : Form
    {
        int CompletedPuzzles;
        public frmWest(int argsCompletedPuzzles)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
        }

        private void picPainting_Click(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            frmNorth frmNorth = new frmNorth(CompletedPuzzles);
            frmNorth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            frmSouth frmSouth = new frmSouth(CompletedPuzzles);
            frmSouth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void picPainting_Click_1(object sender, EventArgs e)
        {
            frmPaintingPuzzle frmPaintingPuzzle = new frmPaintingPuzzle(CompletedPuzzles);
            frmPaintingPuzzle.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmWest_Load(object sender, EventArgs e)
        {

        }
    }
}
