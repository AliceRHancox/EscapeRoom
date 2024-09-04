using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoom
{
    public partial class frmBookshelfPuzzle : Form
    {
        //creates variables completed Puzzles and list of objects as a public vaible
        int CompletedPuzzles;
        List<Puzzles> allPuzzles;
        //does the same as above except one is a const and cannot be changed and one is a new list for only this form
        const string BOOK_CODE = "umbrella";
        List<Books> allBooks = new List<Books>();


        //creates int vaible for time
        int time;

        //gets the sent over variables and puts them into varibales stated in this form
        public frmBookshelfPuzzle(int argsCompletedPuzzles, List<Puzzles> argspuzzle, int argstime)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
            time = argstime;
        }

        //if the back button is hit it will re open the form they came from (south)
        private void btnBack_Click(object sender, EventArgs e)
        {


            frmSouth frmSouth = new frmSouth(CompletedPuzzles, allPuzzles, time);
            frmSouth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmBookshelfPuzzle_Load(object sender, EventArgs e)
        {

            //an array of the different book names
            string[] BookName = {"|The Ili  d|", "|  es Misérables|",  "|  olita|",  "|Jane Eyr  |",
                "|Animal Fa m|", "|The Ho bit|", "|  oby Dick|", "|W  thering heights|" };
            //creates bool done and sets it to false
            bool done = false;

            //for the length of the array..
            for (int i = 0; i < BookName.Length; i++)
            {
                //the book name corresponding to int i, int i and done will be added to a class
                allBooks.Add(new Books(BookName[i], done));
            }

            //for the length of the class all puzzles which is the different puzzles in the game
            for (int i = 0; i < allPuzzles.Count; i++)
            {
                //if the constant stated above equals the passcode for a puzzle in all puzzles class (selects the correct puzzle)
                if (BOOK_CODE == allPuzzles[i].PuzzleCode)
                {
                    //if the bool in that puzzle is already set to true it will tell the user and hide the labels
                    //buttons and text box so they can't enter the code again
                    if (allPuzzles[i].Complete == true)
                    {
                        lblFeedBack.ForeColor = Color.Green;
                        lblFeedBack.Text = "Puzzle already unlocked";
                        txtBoxCode.Visible = false;
                        btnEnter.Visible = false;
                        lblEntercode.Visible = false;
                    }
                }
            }

        }
        //if the button enter us clicked
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //for the length of all the puzzles in the game
            for (int i = 0; i < allPuzzles.Count; i++)
            {
                //if the constant stated above equals the passcode for a puzzle in all puzzles class (selects the correct puzzle)
                if (BOOK_CODE == allPuzzles[i].PuzzleCode)
                {
                    //try and if fail go to catch, stops the code from breaking
                    try
                    {
                        //creates a string of the code the user entered and puts it to lower
                        string EnteredCode = txtBoxCode.Text.ToLower();

                        //if the code they entered is the same code as the constant variable above
                        if (EnteredCode == BOOK_CODE)
                        {
                            //informs the user, hides buttons, puts completed bool in the all puzzles class as true 
                            //meaning the puzzle cannot be completed again. Adds one to the completed puzzle int
                            lblFeedBack.ForeColor = Color.Green;
                            lblFeedBack.Text = "Code accepted. Unlocking puzzle.";
                            allPuzzles[i].Complete = true;
                            txtBoxCode.Visible = false;
                            btnEnter.Visible = false;
                            lblEntercode.Visible = false;
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

        //if end button clicked closed this form and the rest of the systen
        private void btnEnd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        //creates a method which is added into the label apprance of the books
        private void lbl_Paint(object sender, PaintEventArgs e)
        {
            //sets font and size and colour
            Font myfont = new Font("Arial", 14);
            Brush mybrush = new SolidBrush(System.Drawing.Color.Black);
            //sets location and rotation
            e.Graphics.TranslateTransform(30, 220);
            e.Graphics.RotateTransform(-90);

            //for all of the objects in the all books class
            for (int i = 0; i < allBooks.Count; i++)
            {
                //if done equals false
                if (allBooks[i].Done == false)
                {
                    //set the test to the bookname in the class, the font, brush, possition of text
                    e.Graphics.DrawString(allBooks[i].BookName, myfont, mybrush, -30, -20);
                    //sets done to false for that object in the class
                    allBooks[i].Done = true;
                    //ends the for loop by setting i to the total number of all books
                    i = allBooks.Count;
                }


            }


        }
        //adds one to time every time the timer ticks
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void txtBoxCode_Click(object sender, EventArgs e)
        {
            lblFeedBack.Text = "";
        }
    }
}
