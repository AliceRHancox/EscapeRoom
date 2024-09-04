using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoom
{
    public partial class frmPaintingPuzzle : Form
    {
        //creates public variables, one being the constant int which is the code to this puzzle
        int CompletedPuzzles;
        List<Puzzles> allPuzzles;
        const int PAINT_CODE = 10;
        int time;
        //sets public variables to variables sent by previouse form
        public frmPaintingPuzzle(int argsCompletedPuzzles, List<Puzzles> argspuzzle, int argstime)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
            time = argstime;
        }

        //when back button is clicked it will open west form
        private void btnBack_Click(object sender, EventArgs e)
        {

            frmWest frmWest = new frmWest(CompletedPuzzles, allPuzzles, time);
            frmWest.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        //when the form loads..
        private void frmPaintingPuzzle_Load(object sender, EventArgs e)
        {

            //for the length of the all puzzles list of objects (class)
            for (int i = 0; i < allPuzzles.Count; i++)
            {
                //if the paint code is equal to the code in the all puzzles 
                if (Convert.ToString(PAINT_CODE) == allPuzzles[i].PuzzleCode)
                {
                    //if the bool in that puzzle is already set to true it will tell the user and hide the labels
                    //buttons and text box so they can't enter the code again
                    if (allPuzzles[i].Complete == true)
                    {
                        lblFeedBack.ForeColor = Color.Green;
                        lblFeedBack.Text = "Puzzle already unlocked";
                        txtBoxCode.Visible = false;
                        btnEntercode.Visible = false;
                        lblMissingNumber.Visible = false;

                    }
                }
            }

        }
        //when enter is clicked
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //for the length of all the puzzles in the game
            for (int i = 0; i < allPuzzles.Count; i++)
            {
                //if the constant stated above equals the passcode for a puzzle in all puzzles class (selects the correct puzzle)
                if (Convert.ToString(PAINT_CODE) == allPuzzles[i].PuzzleCode)
                {
                    //try and if fail go to catch, stops the code from breaking
                    try
                    {
                        // creates a string of the code the user entered and puts it to lower
                        int EnteredCode = Convert.ToInt32(txtBoxCode.Text);
                        //if the code they entered is the same code as the constant variable above
                        if (EnteredCode == PAINT_CODE)
                        {
                            //informs the user, hides buttons, puts completed bool in the all puzzles class as true 
                            //meaning the puzzle cannot be completed again. Adds one to the completed puzzle int
                            lblFeedBack.ForeColor = Color.Green;
                            lblFeedBack.Text = "Code accepted. Unlocking puzzle.";
                            allPuzzles[i].Complete = true;
                            txtBoxCode.Visible = false;
                            btnEntercode.Visible = false;
                            lblMissingNumber.Visible = false;
                            CompletedPuzzles = CompletedPuzzles + 1;

                        }
                        //if not the same entered code as constant tells user also clears text box so if happens
                        //multiple time the user knows its not bugged
                        else
                        {
                            lblFeedBack.ForeColor = Color.Red;
                            lblFeedBack.Text = "Incorrect code";
                            txtBoxCode.Clear();
                        }
                    }
                    //stops the code from breaking and informs user of the mistake also clears text box so if happens
                    //multiple time the user knows its not bugged
                    catch
                    {
                        lblFeedBack.ForeColor = Color.Red;
                        lblFeedBack.Text = "Invalid input";
                        txtBoxCode.Clear();
                    }
                }
            }
        }
        //When clicked will close form and therefore close game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
        //will add one to int time for each tick
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void txtBoxCode_Clicked(object sender, EventArgs e)
        {
            lblFeedBack.Text = "";
        }
    }
}
