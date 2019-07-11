using System;
using System.Collections.Generic;
using System.Text;

namespace TDDAlura.Core
{
    public class Lance
    {
        public Interessada Cliente {get; set;}
        public double Valor { get; }

    public Lance(Interessada cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
        }

}
}
