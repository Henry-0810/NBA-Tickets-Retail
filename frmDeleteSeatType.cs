using System;
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
    public partial class frmDeleteSeatType : Form
    {
        private static new Form Parent;
        public frmDeleteSeatType(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnDSTback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboChooseSeatTypeToDelete.SelectedItem != null)
            {
                switch (MessageBox.Show("Are you sure you want to delete this?",
                                "NBA Tickets Retail Delete Seat Type",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Seat Type has been deleted", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;

                    case DialogResult.No:
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Choose Seat Type is Blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
