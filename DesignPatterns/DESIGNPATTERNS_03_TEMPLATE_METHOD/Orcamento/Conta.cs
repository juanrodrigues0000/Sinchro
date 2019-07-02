using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_01_
{
    public class Conta
    {
        public String Titular { get;  private set; }
        public double Saldo { get; private set; }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public enum Formato
        {
            XML,
            CSV,
            PORCENTO
        }

        public class Requisicao
        {
            public Formato Formato { get; private set; }

            public Requisicao(Formato formato)
            {
                this.Formato = formato;
            }

        }
    }

}