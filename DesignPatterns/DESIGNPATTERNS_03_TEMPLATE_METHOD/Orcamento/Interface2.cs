using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _DesignPatterns_01_.Conta;

namespace _DesignPatterns_01_
{
    interface Resposta
    {
        void Responde(Requisicao req, Conta conta);
        Resposta OutraResposta { get; set; }
    }

    class RespostaEmXml : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }

}
