using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank;
using ByteBank.Funcionarios;

namespace ByteBank
{
    public interface Autenticavel
    {
        bool Autenticar(string senha);
    }
}
