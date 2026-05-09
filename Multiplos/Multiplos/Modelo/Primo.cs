using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplos.Modelo
{
    public class Primo : AbsPropriedades
    {
        public Primo()
        {
        }

        public Primo(int numero) : base(numero)
        {
        }

        public override void Executar()
        {
            if (numero <= 1)
            {
                mensagem = $"O número {numero} não é primo.";
                return;
            }

            if (numero == 2)
            {
                mensagem = $"O número {numero} é primo.";
                return;
            }

            if (numero % 2 == 0)
            {
                mensagem = $"O número {numero} não é primo.";
                return;
            }

            int limite = (int)Math.Sqrt(numero);

            for (int i = 3; i <= limite; i += 2)
            {
                if (numero % i == 0)
                {
                    mensagem = $"O número {numero} não é primo.";
                    return;
                }
            }

            mensagem = $"O número {numero} é primo.";
        }
    }
}
