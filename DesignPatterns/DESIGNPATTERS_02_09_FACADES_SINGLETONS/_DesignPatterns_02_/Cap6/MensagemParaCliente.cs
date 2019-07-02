using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DesignPatterns_02_
{
    class MensagemParaCliente : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }
        public MensagemParaCliente(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Enviando a mensagem para cliente {0}", nome);
        }
    }
}
