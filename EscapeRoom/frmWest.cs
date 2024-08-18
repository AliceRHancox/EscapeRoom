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
        //creates public variables
        int CompletedPuzzles;
        List<Puzzles> allPuzzles;
        int time;
        //sets public variables to be variables sent across from previous form
        public frmWest(int argsCompletedPuzzles, List<Puzzles> argspuzzle, int argstime)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
            time = argstime;
        }

        //when north button is click it is taken to north form
        private void btnNorth_Click(object sender, EventArgs e)
        {
            frmNorth frmNorth = new frmNorth(CompletedPuzzles, allPuzzles, time);
            frmNorth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
        //when south button is clicked it takes your to south form
        private void btnSouth_Click(object sender, EventArgs e)
        {
            frmSouth frmSouth = new frmSouth(CompletedPuzzles, allPuzzles, time);
            frmSouth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
        //when the painting is clicked it takes you to painting form
        private void picPainting_Click_1(object sender, EventArgs e)
        {
            frmPaintingPuzzle frmPaintingPuzzle = new frmPaintingPuzzle(CompletedPuzzles, allPuzzles, time);
            frmPaintingPuzzle.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmWest_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(time));
        }

        //when end is clicked it will close the form and therefore end the game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        //for each timer tick add one to time
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time++;
        }
    }
}
