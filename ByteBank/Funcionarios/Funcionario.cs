using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(string nome, string cPF)
        {
            Nome = nome;
            CPF = cPF;
        }

        public abstract double GetBonificacao();

        public abstract void AumentoSalarial();
    }
}
