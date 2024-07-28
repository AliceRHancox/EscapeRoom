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
        public frmEast(int argsCompletedPuzzles)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
        }

        private void picWindow_Click(object sender, EventArgs e)
        {
            frmWindowPuzzle frmWindowPuzzle = new frmWindowPuzzle(CompletedPuzzles);
            frmWindowPuzzle.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
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

        private void frmEast_Load(object sender, EventArgs e)
        {

        }
    }
}
