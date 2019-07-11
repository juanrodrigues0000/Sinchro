using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário");

            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.1);
        }
    }
}

