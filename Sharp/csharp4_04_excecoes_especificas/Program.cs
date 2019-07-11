using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                ContaCorrente conta = new ContaCorrente(223,4578564);
                ContaCorrente conta2 = new ContaCorrente(334, 4234412);

                conta2.Transferir(-10, conta);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero")
                {

                }

                Console.WriteLine("Argumento com problema:"+ ex.ParamName); // ParamName aponta o parâmetro que causa erro
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficiente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Console.WriteLine(ContaCorrente.TaxaOperacao);

            Console.ReadLine();
        }

        private static void Metodo()
        {
            ; TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

        }


        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
        }
    }
}
