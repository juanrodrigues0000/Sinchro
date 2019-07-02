using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    interface Visitor
    {
        void ImprimeSoma(Soma soma);

        void ImprimeSubtracao(Subtracao subtracao);

        void ImprimeNumero(Numero numero);

    }
}
