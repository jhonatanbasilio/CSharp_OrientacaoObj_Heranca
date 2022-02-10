using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public abstract class Casa
    {
        public abstract void AbrirPorta();
    }
    /*
     * Antes tinham as duas classes Casa e Carro, exemplo herdaria elas, mas o compilador ficaria em duvida pois ambas tem o metodo com mesmo nome e parametros.
     * Mudamos agora Carro para interface
    public abstract class Carro
    {
        public abstract void AbrirPorta();
    }
    */
    //Note que agora nem usamos o public ou private
    public interface Carro
    {
        void AbrirPorta();
    }
    //Apesar de serem iguais, Casa e Carro, em uma interface jamais poderemos ter a implementação de um metodo, na classe abstrata podemos implementar um metodo desde 
    //que ele não seja abstrato.

    //A ordem sempre será primeiro a herança da classe, depois as interfaces.
    public class Exemplo : Casa , Carro
    {
        //Dessa maneira o compilador sabe que o metodo é a implementação de Casa
        public override void AbrirPorta()
        {
            Console.WriteLine("Porta aberta!");
        }

        /*
         * Se tirar o AbrirPorta() de Casa, a implementação em Exemplo do metodo vindo da interface Carro seria assim:
        public void AbrirPorta()
        {
            Console.WriteLine("Porta aberta!");
        }
        */

        //Ainda assim, evitar usar metodos com o mesmo nome se for fazer algo assim!
    }
}
