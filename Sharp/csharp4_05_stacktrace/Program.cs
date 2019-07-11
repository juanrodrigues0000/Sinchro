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

                //conta2.Transferir(10000, conta);
                conta.Sacar(10000);
            }
           
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna)");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }

            // Console.WriteLine(ContaCorrente.TaxaOperacao);

            Console.WriteLine("Excecução Finalizada. Tecle enter para siar");
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
