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
        //Creates 2 variables
        int CompletedPuzzles;
        List<Puzzles> allPuzzles;
        int time;
        //collects variables sent from previous form and puts them into the variables created above
        public frmEast(int argsCompletedPuzzles, List<Puzzles> argspuzzle, int argstime)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
            time = argstime;
        }
        //If the button window is clicked it will open the form east, sending across 2 variables. It also makes it so if the user re opens the form weill close
        private void picWindow_Click(object sender, EventArgs e)
        {
            frmWindowPuzzle frmWindowPuzzle = new frmWindowPuzzle(CompletedPuzzles, allPuzzles, time);
            frmWindowPuzzle.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
        //same as window but a different button and a different form
        private void btnNorth_Click(object sender, EventArgs e)
        {
            frmNorth frmNorth = new frmNorth(CompletedPuzzles, allPuzzles, time);
            frmNorth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
        //same as window but a different button and a different form
        private void btnSouth_Click(object sender, EventArgs e)
        {
            frmSouth frmSouth = new frmSouth(CompletedPuzzles, allPuzzles, time);
            frmSouth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmEast_Load(object sender, EventArgs e)
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
        //if button clicked it will close the form
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
