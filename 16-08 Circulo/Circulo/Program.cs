using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantiaLado;
            Console.WriteLine("Quantos lados você deseja?");
            quantiaLado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sua forma geometrica tem: {0} lados", quantiaLado);
            Console.ReadKey();
        }
    }
}
