using System;
using System.Collections.Generic;
using System.Text;

namespace Temperatura.modelo
{
    public class Controle : AbsPropriedades
    {
        public Controle(string temp, string tipo) : base(temp, tipo)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            //Validacao validacao = new Validacao(this.temp);

            AbsPropriedades validacao = new Validacao(this.temp);

            if (validacao.ToString().Equals(""))
            {
                AbsPropriedades conversao = new Conversao(validacao.Temperatura, this.tipo);
                this.mensagem = conversao.ToString();
            }
            else
            {
                this.mensagem = validacao.ToString();
            }
        }

        public override string? ToString()
        {
            return mensagem;
        }
    }
}
