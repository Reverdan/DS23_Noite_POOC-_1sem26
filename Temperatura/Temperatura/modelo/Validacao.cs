using System;
using System.Collections.Generic;
using System.Text;

namespace Temperatura.modelo
{
    public class Validacao : AbsPropriedades
    {
        public Validacao(string temp) : base(temp)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            try
            {
                this.Temperatura = Convert.ToDouble(this.temp);
            }
            catch (Exception ex)
            {
                this.mensagem = "Digite valores válidos";
            }
        }

        public override string? ToString()
        {
            return mensagem;
        }

        
    }
}
