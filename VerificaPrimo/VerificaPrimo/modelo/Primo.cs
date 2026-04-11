using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaPrimo.modelo
{
    public class Primo
    {
        #region Atributos
        private string mensagem;
		private int num;
        #endregion

        #region Construtores
        public Primo(int num)
        {
            this.num = num;
            Verificar();
        }
        #endregion

        #region Métodos
        private void Verificar()
        {
            if (num <= 1)
            {
                mensagem = $"O número {num} não é primo.";
                return;
            }

            if (num == 2)
            {
                mensagem = $"O número {num} é primo.";
                return;
            }

            if (num % 2 == 0)
            {
                mensagem = $"O número {num} não é primo.";
                return;
            }

            int limite = (int)Math.Sqrt(num);

            for (int i = 3; i <= limite; i += 2)
            {
                if (num % i == 0)
                {
                    mensagem = $"O número {num} não é primo.";
                    return;
                }
            }

            mensagem = $"O número {num} é primo.";
        }
        #endregion

        #region Propriedades
        public string Mensagem
		{
			get { return mensagem; }
		}
        #endregion

    }
}
