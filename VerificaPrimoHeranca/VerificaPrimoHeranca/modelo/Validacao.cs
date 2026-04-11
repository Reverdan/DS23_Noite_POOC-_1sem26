using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaPrimoHeranca.modelo
{
    public class Validacao : AbsPropriedades
    {
        public Validacao(string numero)
        {
            this.Numero = numero;
            Validar();
        }

        private void Validar()
        {
            this.Mensagem = "";
            try
            {
                this.N1 = Convert.ToInt32(this.Numero);
            }
            catch (Exception ex)
            {
                this.Mensagem = "Número inválido";
            }
        }
    }
}
