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
        //creates int time and sets it equal to the received int from the previous form
        int time;
        

        const int DIVISOR = 10;
        const int MINUTE = 60;
        public frmEndScreen(int argstime)
        {
            InitializeComponent();
            time = argstime;
        }

        //when the button is clicked open the main menu form
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
        //when the form loads set the text of lblshowtime to the time recived from previous form
        private void frmEndScreen_Load(object sender, EventArgs e)
        {
            double totaltime = time / DIVISOR;
            //if its bigger than MINUTE (60), it will divide it by 6 and give it to the user in terms of minutes
            if (totaltime >= MINUTE)
            {
                totaltime = totaltime / MINUTE;
                //rounds it to 2dp
                double roundedValue = Math.Round(totaltime, 2);
                lblShowTime.Text = roundedValue.ToString() + " Minutes";
               
            }
            //if else it will just give in terms of seconds
            else
            {
                lblShowTime.Text = totaltime.ToString() + " Seconds";
            }
           
        }
    }
}
