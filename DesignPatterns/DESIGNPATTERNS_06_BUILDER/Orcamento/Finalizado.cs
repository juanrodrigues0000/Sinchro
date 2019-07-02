using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_01_
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamento finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento já finalizado");
        }
    }
}
