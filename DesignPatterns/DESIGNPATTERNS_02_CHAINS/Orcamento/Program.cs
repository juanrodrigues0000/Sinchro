
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
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));

            Double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }

    }
}
