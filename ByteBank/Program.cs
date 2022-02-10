using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * No contexto atual, a herança multipla (que não é uma classe herdar de 2 ou + classes diferentes e sim uma herança de avô pra pai que vai pra filho) temos o problema
             de criarmos algo que não pertence a classe avô ter que usar a classe pai e assim gerar complicações. Isso ocorre ao criarmos a classe ParceiroComercial que tbm acessa
             o sistema interno mas sem ser um funcionario.
             * Para corrigir isso Autenticavel deixará de herdar Funcionario e passará a ser uma Interface, assim Diretor e GerenteDeConta vão poder usar a herança de Funcionario e
             usar a Interface Autenticavel e o ParceiroComercial vai poder usar Autenticavel sem ser um Funcionario.
            */
            /*
             * Um exemplo de como que é a interface e classe abstrata tá na classe exemplo.
            */

            Console.ReadLine();
        }
    }
}
