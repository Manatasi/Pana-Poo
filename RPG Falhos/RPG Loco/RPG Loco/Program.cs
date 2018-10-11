using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Loco
{
    class Program
    {

        static void Main(string[] args)
        {
            Personagem p = new Personagem();

            Console.WriteLine("Qual o seu nome?");
            p.setNome(Console.ReadLine());

            Console.WriteLine("Certo, {0}, qual a sua Classe?", p.getNome());
            

            Console.ReadKey();
        }
      
    }
}
