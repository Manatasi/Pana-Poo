using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rpg_do_prof
{
    public static class Pergunta
    {
        static ConsoleColor cor = ConsoleColor.DarkYellow;
        public static string RetornoTexto(string texto)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
            return Console.ReadLine();
        }
        public static int RetornoInt(string texto)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
