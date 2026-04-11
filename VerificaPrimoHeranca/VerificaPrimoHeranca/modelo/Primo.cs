using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaPrimoHeranca.modelo
{
    public class Primo : AbsPropriedades
    {
        public Primo(int num)
        {
            this.Num = num;
            Verificar();
        }

        private void Verificar()
        {
            if (Num <= 1)
            {
                Mensagem = $"O número {Num} não é primo.";
                return;
            }

            if (Num == 2)
            {
                Mensagem = $"O número {Num} é primo.";
                return;
            }

            if (Num % 2 == 0)
            {
                Mensagem = $"O número {Num} não é primo.";
                return;
            }

            int limite = (int)Math.Sqrt(Num);

            for (int i = 3; i <= limite; i += 2)
            {
                if (Num % i == 0)
                {
                    Mensagem = $"O número {Num} não é primo.";
                    return;
                }
            }

            Mensagem = $"O número {Num} é primo.";
        }
    }
}
