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
        int time;
        public frmEndScreen(int argstime)
        {
            InitializeComponent();
            time = argstime;
        }


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmEndScreen_Load(object sender, EventArgs e)
        {
            lblShowTime.Text = time.ToString();
        }
    }
}
