using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    class FinalizaPedido : IComando
    {
        private Pedido pedido;
        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            pedido.Finaliza();
        }
    }
}
