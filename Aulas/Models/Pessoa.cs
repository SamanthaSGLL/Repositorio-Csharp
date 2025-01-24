using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.Models // organização das classes 
//posso dar o nome que eu quiser , mas é interessante que tenha caminhos relevantes
{
    public class Pessoa //Significa que o nome da classe é Pessoa
    {
        public string Nome { get; set; } //2 Propriedades da pessoa 
        public int Idade { get; set; } // Get serve para pegar o valor , e quando atribui um valor é set

        public void Apresentar(){ //funcao usando as propriedades
        //Metodo e função é a mesma coisa

           
            Console.WriteLine($"Ola ,meu nome é {Nome},e minha idade é {Idade}"); //parametro
           // Console.WriteLine($"Ola ,meu nome é {Nome}, \n e minha idade é {Idade}"); // quebra de linha
           
           // Console.WriteLine($"Ola ,meu nome é " +
           //$"{Nome},e minha idade é {Idade}");
        }


    }
}