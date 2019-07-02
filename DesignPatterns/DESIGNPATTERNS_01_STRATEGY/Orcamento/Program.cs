﻿using System;
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
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();


            calculador.RealizaCalculo(orcamento, iccc);

            Console.ReadKey();
        }

    }
}
