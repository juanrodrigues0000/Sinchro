using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    interface IMensagem
    {
        IEnviador Enviador { get; set; }
        void Envia();
        string Formata();

    }
}
