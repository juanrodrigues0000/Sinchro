using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    class Pedido
    {
        public string Cliente { get; set; }

        public double valor { get; set; }
        public DateTime DataFinalizacao { get; set; }

        public Status Status { get; set; }

        public Pedido(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.valor = valor;
            this.Status = Status.Novo;
        }
        public void Paga()
        {
            this.Status = Status.Pago;
        }

        public void Finaliza()
        {
            this.Status = Status.Entregue;
            this.DataFinalizacao = DateTime.Now;
        }
    }
}
