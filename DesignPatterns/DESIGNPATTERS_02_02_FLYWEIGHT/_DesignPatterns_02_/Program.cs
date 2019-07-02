using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();

            IList<INota> musica = new List<INota>()
            {
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("Fa"),
            notas.Pega("Fa"),
            notas.Pega("Fa"),
            };

        Piano piano = new Piano();

        piano.Toca(musica);
        }
    }
}
