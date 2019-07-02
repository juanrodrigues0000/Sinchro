using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _DesignPatterns_02_
{
    class Program
    {
        static void Main(string[] args)
        {
            String cpf = "1234";
            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);

            var fatura = facade.CriaFatura(cliente, 5000);
            facade.GeraCobranca(tipo.Boleto, fatura)


        }

        
    }
}
