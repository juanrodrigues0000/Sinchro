using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_01_
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }

}