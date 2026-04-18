using System;
using System.Collections.Generic;
using System.Text;

namespace Temperatura.modelo
{
    public abstract class AbsPropriedades : IMetodos
    {
        public String mensagem;
        public String resposta;
        public String temp;
        public Double temperatura;
        public String tipo;

        protected AbsPropriedades(string temp)
        {
            this.temp = temp;
            this.Executar();
        }

        protected AbsPropriedades(double temperatura, string tipo)
        {
            this.temperatura = temperatura;
            this.tipo = tipo;
            this.Executar();
        }

        protected AbsPropriedades(string temp, string tipo)
        {
            this.temp = temp;
            this.tipo = tipo;
            this.Executar();
        }

        public abstract void Executar();
    }
}
