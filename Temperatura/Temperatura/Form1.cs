using Temperatura.modelo;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Controle controle;
            if (rdbCF.Checked)
            {
                controle = new Controle(txbTemperatura.Text, "FC");
            }
            else
            {
                controle = new Controle(txbTemperatura.Text, "CF");
            }
            lblResultado.Text = controle.ToString();
        }
    }
}
