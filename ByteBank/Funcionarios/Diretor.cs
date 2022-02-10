using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string nome, string cPF) : base(nome, cPF)
        {
            Senha = "123456";
            Salario = 5000;
        }

        //Aumento é de 30%
        public override void AumentoSalarial()
        {
            Salario *= 1.30;
        }
        
        //Bonificação anual é de 50%
        public override double GetBonificacao()
        {
            return Salario *= 0.5;
        }
        
    }
}
