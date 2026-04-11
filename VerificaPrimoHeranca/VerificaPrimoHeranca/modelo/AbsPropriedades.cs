using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaPrimoHeranca.modelo
{
    public abstract class AbsPropriedades
    {
		private string mensagem;
		private int n1;
		private int num;
		private string numero;


		public string Numero
		{
			get { return numero; }
			set { numero = value; }
		}


		public int Num
		{
			get { return num; }
			set { num = value; }
		}


		public int N1
		{
			get { return n1; }
			set { n1 = value; }
		}


		public string Mensagem
		{
			get { return mensagem; }
			set { mensagem = value; }
		}

	}
}
