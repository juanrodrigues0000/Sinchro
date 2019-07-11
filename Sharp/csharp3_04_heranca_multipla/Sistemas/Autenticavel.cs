using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank;
using ByteBank.Funcionarios;

namespace ByteBank.Funcionarios
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        public Autenticavel(double salario, string cpf)
            :base(salario, cpf)
        {

        }


        public bool Autenticar (string senha)
        {
            return Senha == senha;
        }
    }
}
