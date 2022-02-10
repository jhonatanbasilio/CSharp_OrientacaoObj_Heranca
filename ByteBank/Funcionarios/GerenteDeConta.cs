using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string nome, string cPF) : base(nome, cPF)
        {
            Senha = "123456";
            Salario = 3500;
        }

        //Aumento é de 15%
        public override void AumentoSalarial()
        {
            this.Salario *= 1.15;
        }

        //Bonificação anual é de 10%
        public override double GetBonificacao()
        {
            return Salario *= 0.1;
        }
    }
}
