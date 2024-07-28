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
    public partial class frmBookshelfPuzzle : Form
    {
        public frmBookshelfPuzzle()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSouth frmSouth = new frmSouth();
            frmSouth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmBookshelfPuzzle_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            const string BOOK_CODE = "umbrella";
            try
            {
                string EnteredCode = txtBoxCode.Text.ToLower();
                if (EnteredCode == BOOK_CODE)
                {
                    lblFeedBack.ForeColor = Color.Green;
                    lblFeedBack.Text = "Code accepted. Unlocking puzzle.";
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
