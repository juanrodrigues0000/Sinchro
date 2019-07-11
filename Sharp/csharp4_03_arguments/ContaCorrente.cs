// using _05_ByteBank;
using System;

namespace ByteBank
{
    public class ContaCorrente
    {

        private static double TaxaOperacao;
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }

        public int Numero { get; }
        public int Agencia { get; }

        private double _saldo = 100;
        public double Saldo
        {

            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int NumeroAgencia, int numero) // "NumeroAgencia está substituindo "agencia" nb uso de nameof
        {
            if(NumeroAgencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior do que 0", nameof(NumeroAgencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("O argumento numero precisa ser maior do que 0", "agencia");
            }

            Agencia = NumeroAgencia;
            Numero = numero;

            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
