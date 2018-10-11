using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rpg_do_prof
{
    static class Menu
    {
        private enum Lutando
        {
            Atacar = 0,
            Fugir = 1,
            Ver_inventário = 2,
            Ver_habilidades = 3
        }

        public static string Luta()
        {
            string mensagem = "-------\nAções:\n";
            Lutando[] elementos = Enum.GetValues(typeof(Lutando)) as Lutando[];
            foreach (Lutando n in elementos)
            {
                int valor = (int)n;
                string texto = n.ToString();
                mensagem += valor + " => " + texto + "\n";
                mensagem = mensagem.Replace('_', ' ');
            }
            return mensagem;
        }
    }
}
