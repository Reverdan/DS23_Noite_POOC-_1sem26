using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaPrimo.modelo
{
    public class Validacao
    {
		private string mensagem;
		private int n1;
		private string numero;

        public Validacao(string numero)
        {
            this.numero = numero;
			Validar();
        }

		private void Validar()
		{
			this.mensagem = "";
			try
			{
				this.n1 = Convert.ToInt32(this.numero);
            }
			catch (Exception ex)
			{
				this.mensagem = "Número inválido";
			}
        }

        public int N1
		{
			get { return n1; }
		}


		public string Mensagem
		{
			get { return mensagem; }
		}

	}
}
