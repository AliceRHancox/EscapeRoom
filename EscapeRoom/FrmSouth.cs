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
        public frmSouth()
        {
            InitializeComponent();
        }

        private void picBookShelf_Click(object sender, EventArgs e)
        {
            frmBookshelfPuzzle frmBookshelfPuzzle = new frmBookshelfPuzzle();
            frmBookshelfPuzzle.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            frmEast frmEast = new frmEast();
            frmEast.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            frmWest frmWest = new frmWest();
            frmWest.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
