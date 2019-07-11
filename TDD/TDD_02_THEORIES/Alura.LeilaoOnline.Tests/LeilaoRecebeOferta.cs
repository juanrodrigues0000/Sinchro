using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Alura.LeilaoOnline.Core;
using System.Linq;

namespace LeilaoTerminaPregao
{
    public class LeilaoRecebeOferta
    {
        [Fact]
        public void NãoPermiteNovosLancesDadoLeilaoFinalizado()
        {
            //Arranje - cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(fulano, 800);
            leilao.TerminaPregao();

            //Act - método sob teste
            leilao.RecebeLance(fulano, 1000);

            //Assert
            var valorEsperado = 2;
            var valorObtido = leilao.Lances.Count();
            Assert.Equal(valorEsperado, valorObtido);

        }

    }
}
