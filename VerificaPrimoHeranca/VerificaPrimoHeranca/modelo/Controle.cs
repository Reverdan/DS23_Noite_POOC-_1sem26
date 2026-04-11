using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaPrimoHeranca.modelo
{
    public class Controle : AbsPropriedades
    {
        public Controle(string numero)
        {
            this.Numero = numero;
            this.Executar();
        }

        private void Executar()
        {
            this.Mensagem = "";
            Validacao validacao = new Validacao(this.Numero);
            if (validacao.Mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.N1);
                this.Mensagem = primo.Mensagem;
            }
            else
            {
                this.Mensagem = validacao.Mensagem;
            }
        }
    }
}
