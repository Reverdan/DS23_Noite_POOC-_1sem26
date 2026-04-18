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
            Validacao validacao = new Validacao(this.temp);
            if (validacao.mensagem.Equals(""))
            {
                Conversao conversao = new Conversao(validacao.temperatura, this.tipo);
                this.mensagem = conversao.resposta;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
