using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplos.Modelo
{
    public abstract class AbsPropriedades : IntMetodos
    {
        protected String numero1;
        protected String numero2; 
        protected String numero3;
        protected Double lado1;
        protected Double lado2;
        protected Double lado3;
        protected String resposta;
        protected Int32 numero;
        protected String mensagem;

        protected AbsPropriedades(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.Executar();
        }

        protected AbsPropriedades(string numero1, string numero2, string numero3)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            this.numero3 = numero3;
            this.Executar();
        }

        protected AbsPropriedades(string numero1)
        {
            this.numero1 = numero1;
            this.Executar();
        }

        protected AbsPropriedades(int numero)
        {
            this.numero = numero;
            this.Executar();
        }

        protected AbsPropriedades()
        {
        }

        public String Mensagem
        {
            get { return mensagem; }
        }

        public abstract void Executar();

        public override string? ToString()
        {
            return this.mensagem;
        }
    }
}
