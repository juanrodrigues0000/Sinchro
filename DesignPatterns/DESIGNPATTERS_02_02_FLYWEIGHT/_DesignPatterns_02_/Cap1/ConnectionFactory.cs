using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "user id=root;Password;Server=localhost;Database=meuBanco";
            conexao.Open();

            return conexao;
        }
    }
}
