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
        public frmWest()
        {
            InitializeComponent();
        }

        private void picPainting_Click(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            frmNorth frmNorth = new frmNorth();
            frmNorth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            frmSouth frmSouth = new frmSouth();
            frmSouth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
