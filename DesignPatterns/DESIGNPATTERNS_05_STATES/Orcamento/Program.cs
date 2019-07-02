
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
            Orcamento reforma = new Orcamento(500);

            Console.WriteLine(reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);


            Console.ReadKey();
        }

    }
}
