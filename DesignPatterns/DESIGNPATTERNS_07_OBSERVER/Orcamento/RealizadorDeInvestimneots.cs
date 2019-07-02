using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_01_
{
    
    public class RealizadorDeInvestimentos
    {
        public void Realiza(Conta conta, Investimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Deposita(resultado * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
