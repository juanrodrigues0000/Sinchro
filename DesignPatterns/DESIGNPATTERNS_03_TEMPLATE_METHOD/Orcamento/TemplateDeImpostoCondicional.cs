﻿using _DesignPatterns_01_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OesignPatterns_01_
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
           public double Calcula(Orcamento orcamento)
            {
                if (DeveUsarMaximaTaxacao(orcamento))
                {
                    return MaximaTaxacao(orcamento);
                }

                return MinimaTaxacao(orcamento);
            }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
