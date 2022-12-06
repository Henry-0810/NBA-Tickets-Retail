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
    public partial class frmCheckAvailability : Form
    {
        private static new Form Parent;
        public frmCheckAvailability(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnCAback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
    }
}
