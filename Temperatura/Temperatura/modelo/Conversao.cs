using System;
using System.Collections.Generic;
using System.Text;

namespace Temperatura.modelo
{
    public class Conversao : AbsPropriedades
    {
        public Conversao(double temperatura, string tipo) : base(temperatura, tipo)
        {
        }

        public override void Executar()
        {
            if (this.tipo.Equals("CF"))
            {
                this.resposta = ((this.temperatura - 32) * 5 / 9).ToString();

            }
            else
            {
                this.resposta = ((this.temperatura * 9 / 5) + 32).ToString();
            }
        }
    }
}
