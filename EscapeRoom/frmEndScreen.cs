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
    public partial class frmEndScreen : Form
    {
        string Name = " ";
        string TestName;
        public frmEndScreen()
        {
            InitializeComponent();
        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {


            frmLeaderBoard frmLeaderBoard = new frmLeaderBoard();
            frmLeaderBoard.ShowDialog();
            System.Windows.Forms.Application.ExitThread();


        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            TestName = txtBoxName.Text;
            CheckingForInvalidName(TestName);
        }
        private void CheckingForInvalidName(String TestName)
        {
            //creates a constant int of the max characters the name can have and make it equal to 20
            const int MAX_NAME_CHARACTERS = 20;
            //Splits the entered name into different characters and puts it in an array 
            char[] SplitName = TestName.ToCharArray();

            //creates an int called no spaces and sets it to 0
            int NoSpaces = 0;

            //for the length of the split name character array thus loop will run
            for (int i = 0; i < SplitName.Length; i++)
            {
                //will put the character that is currently looping through in a char called letter
                char Letter = SplitName[i];
                //if the letter isn't equal to a space it will add one to nospaces int
                if (Letter != ' ')
                {
                    NoSpaces++;

                }

            }

            //If they didn't enter anything in the text box it will put a message in a label, make it red and clear the text box
            if (SplitName.Length <= 0)
            {
                lblWrong.ForeColor = Color.Red;
                lblWrong.Text = "That is an invalid input. Please enter a name.";
                txtBoxName.Clear();
            }
            //If the name they entered it is over MAX_NAME_CHARACTERS characters it will put a message in a label, make it red and clear the text box
            else if (SplitName.Length > MAX_NAME_CHARACTERS)
            {
                lblWrong.ForeColor = Color.Red;
                lblWrong.Text = "That is an invalid input. Please do not enter a name over 20 Characters";
                txtBoxName.Clear();
            }
            //if the no spaces int is the same number as the legnth of the name it will take you to the next form - i.e no spaces in the name
            else if (NoSpaces == SplitName.Length)
            {
                Name = TestName;
                txtBoxName.Visible = false;
                lblWrong.Visible = false;
                lblPlease.Visible = false;
                btnEnter.Visible = false;
                btnLeaderBoard.Visible = true;
                btnMainMenu.Visible = true;

            }
            //if Nospaces int isn't equal to the name legnth, the name entered didn't have 0 character or is bigger than 50 it will it will put a message in a label, make it red and clear the text box
            else
            {
                lblWrong.ForeColor = Color.Red;
                lblWrong.Text = "That is an invalid input. Please do not enter a space in your name";
                txtBoxName.Clear();

            }
        }
        private void AddToLeaderboard()
        {

        }


    }
}
