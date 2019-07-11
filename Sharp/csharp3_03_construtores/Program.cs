using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            public void CalcularBonificacao()
            {
                GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

                Designer pedro = new Designer("cpf teste 1");
                pedro.Nome = "Pedro";

                Diretor roberta = new Diretor("cpf teste 2");
                roberta.Nome = "Roberta";

                Auxiliar Igor = new Auxiliar("cpf teste 3");
                igor.Nome = "Igor";

                GerenteDeConta Camila = new GerenteDeConta("cpf teste 4");
                camila.Nome = "Camila";
         
            }

            GerenciadorBonificacao.Registrar(pedro);
            GerenciadorBonificacao.Registrar(roberta);
            GerenciadorBonificacao.Registrar(igor);
            GerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificações do mês " + GerenciadorBonificacao.getTotalBonificacao)

            Console.ReadLine();

        }
    }
}
