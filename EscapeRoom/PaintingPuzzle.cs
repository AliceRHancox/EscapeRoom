﻿using System;
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
    public partial class frmPaintingPuzzle : Form
    {
        public frmPaintingPuzzle()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWest frmWest = new frmWest();
            frmWest.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
