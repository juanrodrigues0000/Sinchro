﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TDDAlura.Core
{
    public class Leilao
    {
        private IList<Lance> _lances;
        public IEnumerable<Lance> Lances => _lances;
        public string Peca { get; }
        public Lance Ganhador { get; private set; }


        public Leilao(string peca)
        {
            Peca = peca;
            _lances = new List<Lance>();
        }

        public void RecebeLance(Interessada cliente, double valor)
        {
            _lances.Add(new Lance(cliente, valor));
        }

        public void IniciaPregao()
        {

        }
        public void TerminaPregao()
        {
           // Ganhador = Lances;
                //.OrderBy(1 => 1,Valor)
                //.Last(); 
                
            Console.WriteLine("XOW!");
        }
    }
}
