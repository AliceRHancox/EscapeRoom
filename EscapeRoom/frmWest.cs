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
        List<Puzzles> allPuzzles;
        int time;
        public frmWest(int argsCompletedPuzzles, List<Puzzles> argspuzzle, int argstime)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
            time = argstime;
        }

        private void picPainting_Click(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            frmNorth frmNorth = new frmNorth(CompletedPuzzles, allPuzzles, time);
            frmNorth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            frmSouth frmSouth = new frmSouth(CompletedPuzzles, allPuzzles, time);
            frmSouth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void picPainting_Click_1(object sender, EventArgs e)
        {
            frmPaintingPuzzle frmPaintingPuzzle = new frmPaintingPuzzle(CompletedPuzzles, allPuzzles, time);
            frmPaintingPuzzle.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmWest_Load(object sender, EventArgs e)
        {
            if (time == 10)
            {
                MessageBox.Show(Convert.ToString(time));
            }
            else if (time == 20)
            {
                MessageBox.Show(Convert.ToString(time));
            }

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time++;
        }
    }
}
