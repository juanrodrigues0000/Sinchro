using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();

            UsarSistema();

          Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemainterno = new SistemaInterno();

            Diretor roberta = new Diretor("cpf teste 2");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("cpf teste 4");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemainterno.Logar(parceiro, "123456");

            sistemainterno.Logar(roberta, "123");
            sistemainterno.Logar(camila, "abc");
        }


        public static void CalcularBonificacao()

            {
                GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

                Designer pedro = new Designer("cpf teste 1");
                pedro.Nome = "Pedro";

                Diretor roberta = new Diretor("cpf teste 2");
                roberta.Nome = "Roberta";
                roberta.Senha = "123";

                Auxiliar igor = new Auxiliar("cpf teste 3");
                igor.Nome = "Igor";

                GerenteDeConta camila = new GerenteDeConta("cpf teste 4");
                camila.Nome = "Camila";
                camila.Nome = "abc";

                Desenvolvedor guilherme = new Desenvolvedor("cpf teste 4");
                guilherme.Nome = "Guilherme";

                gerenciadorBonificacao.Registrar(pedro);
                gerenciadorBonificacao.Registrar(roberta);
                gerenciadorBonificacao.Registrar(igor);
                gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

                Console.WriteLine("Total de Bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());

            }

        }
}
