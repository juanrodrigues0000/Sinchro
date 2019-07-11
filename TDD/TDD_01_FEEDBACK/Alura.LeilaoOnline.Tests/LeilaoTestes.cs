using System;
using System.Collections.Generic;
using System.Text;
using TDDAlura.Core;

namespace Alura.LeilaoOnline.Tests
{
    class LeilaoTestes
    {

        private static void LeilaoComVariosLances()
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

            Verifica(valorEsperado, valorObtido);

            Console.ReadKey();
        }

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

            Verifica(valorEsperado, valorObtido);

            Console.ReadKey();
        }
    }
}
