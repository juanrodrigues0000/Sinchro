﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    interface IExpressao
    {
        int Avalia();

        void Aceita(Visitor impressora);
    }

}
