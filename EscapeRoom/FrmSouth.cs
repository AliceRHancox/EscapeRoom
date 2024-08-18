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
        //creates public variables
        int CompletedPuzzles;
        List<Puzzles> allPuzzles;
        int time;
        //gets varibles from previous from and sets then puts them in public variables

        public frmSouth(int argsCompletedPuzzles, List<Puzzles> argspuzzle, int argstime)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
            time = argstime;
        }

        //when the picture is clicked take to the form
        private void picBookShelf_Click(object sender, EventArgs e)
        {
            frmBookshelfPuzzle frmBookshelfPuzzle = new frmBookshelfPuzzle(CompletedPuzzles, allPuzzles, time);
            frmBookshelfPuzzle.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
        //when the button is clicked take to the next form (east)
        private void btnEast_Click(object sender, EventArgs e)
        {

            frmEast frmEast = new frmEast(CompletedPuzzles, allPuzzles, time);
            frmEast.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        //when button is clicked take to the next form (west)
        private void btnWest_Click(object sender, EventArgs e)
        {

            frmWest frmWest = new frmWest(CompletedPuzzles, allPuzzles,  time);
            frmWest.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmSouth_Load(object sender, EventArgs e)
        {
           
        }

        //when end is clicked close the form and therefore the game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        //when the timer ticks time goes up by one
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time++;
        }
    }
}
