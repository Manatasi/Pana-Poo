using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int larguraTela = 80;
            int alturaTela = 50;
            Console.SetWindowSize(larguraTela, alturaTela);

            Grafico g = new Grafico(larguraTela, alturaTela);
            //g.gerarQuadrado(59, 10, 10);
            List<string> a = new List<string>();
     

            g.gerarForma(50, 0, 19, 14, ConsoleColor.Blue, a); //Personagem 65 largura 1 altura



            Console.ReadLine();
        }
    }
}
