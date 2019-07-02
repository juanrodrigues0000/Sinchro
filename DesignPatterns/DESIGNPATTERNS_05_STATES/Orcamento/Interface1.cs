using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _DesignPatterns_01_.Conta;

namespace _DesignPatterns_01_
{
    public class RespostaEmPorcento : Resposta
    {
        private Resposta OutraResposta { get; set; }
        Resposta Resposta.OutraResposta { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }

    }
}
