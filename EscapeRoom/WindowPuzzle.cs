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
    public partial class frmWindowPuzzle : Form
    {
        public frmWindowPuzzle()
        {
            InitializeComponent();
        }

        private void frmWindowPuzzle_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEast frmEast = new frmEast();
            frmEast.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
