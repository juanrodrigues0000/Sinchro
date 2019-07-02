
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_01_
{

    class Program
    {
        static void Main(string[] args)
        {


            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            criador.AdicionaAcao(new EnviadorPorEmail());
            criador.AdicionaAcao(new NotaFiscalDao());
            criador.AdicionaAcao(new EnviadorPorSms());

            criador
                .ParaEmpresa("Caelum Ensino e Inovação")
                .ComCnpj("23.456.678/0001-12")
                .ComItem(new ItemDaNota("Item 1", 100.0))
                .ComItem(new ItemDaNota("Item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("uma obs qualquer");

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
                       
            Console.ReadKey();
        }

    }
}
