﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void seatTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void addSeatTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddSeatType frmAddSeatType = new frmAddSeatType(this);
            frmAddSeatType.Show();
        }

        private void checkAvailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateSeatTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateSeatType frmUpdateSeatType = new frmUpdateSeatType(this);
            frmUpdateSeatType.Show();
            Visible = false;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
