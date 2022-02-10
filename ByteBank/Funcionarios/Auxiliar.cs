using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, string cPF) : base(nome, cPF)
        {
            Salario = 2000;
        }

        //Aumento salarial de uma Auxiliar é de 10%
        public override void AumentoSalarial()
        {
            Salario *= 1.1;
        }

        //A bonificação anual de um Auxiliar é de 5%
        public override double GetBonificacao()
        {
            return Salario *= 0.05;
        }
    }
}
