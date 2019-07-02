using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return ClienteDAO().BuscaPorCpf(cpf);
        }

        public Fatura CriarFatura (Cliente cliente, double valor)
        {

            return new Fatura(cliente, valor);
        }

        public Cobranca GeraCobranca(Tipo tipo, fatura fatura)
        {
            Cobranca cobranca = new Cobranca(tipo, fatura);
            cobranca.Emite();
            return cobranca;
        }
        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca){
        {
             ContatoCliente contato = new ContatoCliente(cliente, cobranca);
             contato.Dispara();
             return contato;
        }

    }
}
