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
    public partial class frmYearlyRevenueAnalysis : Form
    {
        private static new Form Parent;
        public frmYearlyRevenueAnalysis(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnYRAback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
    }
}
