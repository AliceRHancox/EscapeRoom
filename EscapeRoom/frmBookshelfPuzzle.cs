using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoom
{
    public partial class frmBookshelfPuzzle : Form
    {
        int CompletedPuzzles;
        List<Puzzles> allPuzzles;
        const string BOOK_CODE = "umbrella";
        List<Books> allBooks = new List<Books>();
        int time;
        public frmBookshelfPuzzle(int argsCompletedPuzzles, List<Puzzles> argspuzzle)
        {
            InitializeComponent();
            CompletedPuzzles = argsCompletedPuzzles;
            allPuzzles = argspuzzle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSouth frmSouth = new frmSouth(CompletedPuzzles, allPuzzles, time);
            frmSouth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmBookshelfPuzzle_Load(object sender, EventArgs e)
        {
            string[] BookName = { "|W  thering heights|", "|  oby Dick|", "|Tess of the d’Ur  ervilles|", "|Oedipus   ex|",
            "|Jane Eyr  |", "|  oita|", "|  es Misérables|", "|The Ili  d|"};
            bool done = false;
            for (int i = 0; i < BookName.Length; i++)
            {

                allBooks.Add(new Books(BookName[i], i, done));
            }
            for (int i = 0; i < allPuzzles.Count; i++)
            {
                if (BOOK_CODE == allPuzzles[i].PuzzleCode)
                {
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




            if (time == 10)
            {
                MessageBox.Show(Convert.ToString(time));
            }
            else if (time == 20)
            {
                MessageBox.Show(Convert.ToString(time));
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < allPuzzles.Count; i++)
            {
                if (BOOK_CODE == allPuzzles[i].PuzzleCode)
                {

                    try
                    {
                        string EnteredCode = txtBoxCode.Text.ToLower();
                        if (EnteredCode == BOOK_CODE)
                        {
                            lblFeedBack.ForeColor = Color.Green;
                            lblFeedBack.Text = "Code accepted. Unlocking puzzle.";
                            allPuzzles[i].Complete = true;
                            txtBoxCode.Visible = false;
                            btnEnter.Visible = false;
                            lblEntercode.Visible = false;
                            CompletedPuzzles = CompletedPuzzles + 1;
                        }
                        else
                        {
                            lblFeedBack.ForeColor = Color.Red;
                            lblFeedBack.Text = "Incorrect code";

                        }
                    }
                    catch
                    {
                        lblFeedBack.ForeColor = Color.Red;
                        lblFeedBack.Text = "Invalid input";
                    }


                }

            }

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void lbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Arial", 14);
            Brush mybrush = new SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(30, 220);
            e.Graphics.RotateTransform(-90);
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i].Done == false)
                {
                    e.Graphics.DrawString(allBooks[i].BookName, myfont, mybrush, -30, -20);
                    allBooks[i].Done = true;
                    i = allBooks.Count;
                }


            }


        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time++;
        }
    }
}
