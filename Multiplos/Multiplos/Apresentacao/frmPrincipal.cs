using Multiplos.Apresentacao;

namespace Multiplos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void tsmTriangulos_Click(object sender, EventArgs e)
        {
            frmTriangulos frmT = new frmTriangulos();
            this.Visible = false;
            frmT.ShowDialog();
            this.Visible = true;
        }

        private void tsmFatorial_Click(object sender, EventArgs e)
        {
            frmFatorial frmF = new frmFatorial();
            frmF.Show();
        }

        private void tsmPrimo_Click(object sender, EventArgs e)
        {
            frmPrimo frmP = new frmPrimo();
            frmP.ShowDialog();
        }
    }
}
