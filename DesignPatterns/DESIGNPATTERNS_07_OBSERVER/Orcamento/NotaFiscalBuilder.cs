using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _DesignPatterns_01_.NotaFiscal;

namespace _DesignPatterns_01_
{
    public class NotaFiscalBuilder
    {

        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public String Observacoes { get; private set; }
        private double valorTotal;
        private double impostos;
        public DateTime Data { get; private set; }
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();
        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

            foreach(AcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }
            return nf;
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);

        }

        public NotaFiscal ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscal ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;

            return this;
        }

        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            this.Data = novaData;

            return this;
        }


        public NotaFiscal ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscal ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }
    }
}
