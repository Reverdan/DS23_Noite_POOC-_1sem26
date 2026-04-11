using VerificaPrimo.modelo;

namespace VerificaPrimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero.Text);
            lblResposta.Text = controle.Mensagem;
        }
    }
}
