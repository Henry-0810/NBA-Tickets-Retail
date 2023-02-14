using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmViewTeams : Form
    {
        private static new Form Parent;
        public frmViewTeams(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmViewTeams_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }
    }
}
