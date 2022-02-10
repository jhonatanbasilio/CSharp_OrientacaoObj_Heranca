using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; private set; }

        public ParceiroComercial(string senha)
        {
            Senha = "123456";
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public bool AlterarSenha(string senhaNova, string senhaAtual)
        {
            if(Senha == senhaAtual)
            {
                Senha = senhaNova;
                return true;
            }
            else
            {
                Console.WriteLine("\nA senha atual digitada está incorreta!!!\n");
                return false;
            }
        }
    }
}
