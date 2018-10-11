using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equação do segundo grau.");
            EquacaoSegundoGrau e = new EquacaoSegundoGrau(10, 6, 10);
            Console.WriteLine(e.ToString());
            Console.WriteLine("Distancia entre pontos tridimencional.");
            Distancia d = new Distancia(4, -8, -9, 2, -3, -5);
            Console.WriteLine(d.calculaDistanciaTridimencional());
            Console.WriteLine("Distancia entre pontos bidimencional.");
            Distancia d2 = new Distancia(1,1,4,5);
            Console.WriteLine(d2.calculaDistanciaTridimencional());
            Ponto p = new Ponto(1,2,3);
            Console.WriteLine(p.ToString());
            Console.WriteLine(d2.ToString());
            Console.ReadLine();

        }
    }
}
