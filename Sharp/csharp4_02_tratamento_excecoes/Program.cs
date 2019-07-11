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
                Metodo();
            }
            catch (DivideByZeroException e)
            { 
                Console.WriteLine("Não é possível dividir por zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro!!!");
            }

            ContaCorrente conta = new ContaCorrente(7488, 7382779);

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
