using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    class Program
    {
        static void Main(string[] args)
        {
            IMensagem mensagem = new MensagemAdministrativa("victor");
            IEnviador enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();

            Console.ReadKey();
        }
    }
}
