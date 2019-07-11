using System;
using TDDAlura.Core;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    class Program
    {

        public void Verifica(double valorEsperado,double valorObtido)
        {
            var cor = Console.ForegroundColor;
            if (valorEsperado == valorObtido)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Funcionalidade válida");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Funcionalidade inválida");
            }
            Console.ForegroundColor = cor;
        }

        [Fact]
        public void LeilaoComVariosLances()
        {

            // A - Arrange - Cenário


            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 990);


            //  Act - Método sob teste 
            leilao.TerminaPregao();

            // Assert - Verificação

            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;

            Assert.Equal(valorEsperado, valorObtido);

            Console.ReadKey();
        }

        [Fact]
        private static void LeilaoComApenasUmLance()
        {
            // A - Arrange - Cenário


            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);

            leilao.RecebeLance(fulano, 800);

            //  Act - Método sob teste 
            leilao.TerminaPregao();

            // Assert - Verificação

            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;

            Assert.Equal(valorEsperado, valorObtido);

            Console.ReadKey();
        }

        static void Main()
        {
            LeilaoComVariosLances();
            LeilaoComApenasUmLance();
        }
    }
}
