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
        //Creates public variables (that can be accessed from all methods in this form). One is a constant int and therefore can only be changed from 3 where it is first declaired
        int CompletedPuzzles;
        const int MAX_PUZZLES = 3;
        List<Puzzles> allPuzzles;

        // collects variables sent here from previous form and puts them into some of the variable declaired above
        public frmNorth(int argsCompletedPuzzles, List<Puzzles> argspuzzle)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
        }
        //When the form loards the label lblProgress will stated the number of puzzles completed out of the max number of puzzles 
        private void frmNorth_Load(object sender, EventArgs e)
        {
            lblProgress.Text = "Puzzles completed" + Environment.NewLine + CompletedPuzzles + "/" + MAX_PUZZLES;
        }
        //when the picture box door is click
        private void picDoor_Click(object sender, EventArgs e)
        {
            //If the number of completed puzzles equals the number of max puzzles the end screen will play
            if(CompletedPuzzles == MAX_PUZZLES)
            {
                frmEndScreen frmEndScreen = new frmEndScreen();
                frmEndScreen.ShowDialog();
                System.Windows.Forms.Application.ExitThread();
            }
        }
        //If the button east is clicked it will open the form east, sending across 2 variables. It also makes it so if the user re opens the form weill close
        private void btnEast_Click(object sender, EventArgs e)
        {
            frmEast frmEast = new frmEast(CompletedPuzzles, allPuzzles);
            frmEast.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
        //same as east but a different button and a different form
        private void btnWest_Click(object sender, EventArgs e)
        {
            frmWest frmWest = new frmWest(CompletedPuzzles, allPuzzles);
            frmWest.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        //if this button is clicked the form will close
        private void btnEnd_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
