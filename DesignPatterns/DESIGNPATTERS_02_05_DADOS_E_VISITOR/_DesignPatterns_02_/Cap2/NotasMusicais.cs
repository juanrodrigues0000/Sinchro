using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    class NotasMusicais
    {
        private static IDictionary<string, INota> notas =
            new Dictionary<string, INota>()
            {
            {"do", new Do()},
            {"re", new Re()},
            {"mi", new Mi()},
            {"Fa", new Fa()},
            {"Sol",new Sol()},
            {"La", new La()},
            {"Si", new Si()}
            };

    public INota Pega(string nome)
        {
            return notas[nome];
        }

    }
}
