using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; protected set; }
        public FuncionarioAutenticavel(string nome, string cPF) : base(nome, cPF)
        {
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public bool AlterarSenha(string senhaNova, string senhaAtual)
        {
            if (Senha == senhaAtual)
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
