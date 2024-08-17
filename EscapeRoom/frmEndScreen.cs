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
            lblShowTime.Text = time.ToString();
        }
    }
}
