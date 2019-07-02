
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_01_
{

    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();

            Orcamento orcamento = new Orcamento(500);

            iss.Calcula(orcamento);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();
        }

    }
}
