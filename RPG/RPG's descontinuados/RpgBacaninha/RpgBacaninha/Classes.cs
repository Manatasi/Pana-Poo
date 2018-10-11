using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgBacaninha
{
    class Classes
    {
        public enum Classe
        {
            NãoEncontrado = 0,
            Guerreiro = 1,
            Arqueiro = 2,
            Mago = 3,
            Ladino = 4
        };


        public Classe[] getNomeClasses()
        {
            Classe[] elementos = Enum.GetValues(typeof(Classe)) as Classe[];
            return elementos;
        }       

        public Classe selecionarClasseId(int selecao)
        {
            Classe enu = Classe.NãoEncontrado;

            foreach (Classe n in getNomeClasses())
            {
                if (selecao == (int)n)
                {
                    enu = n;
                }
            }
            return enu; //retorna a classe selecionada. você pode estar vendo o codigo da classe convertando para inteiro, ou vendo o nome convertendo para string
                        // n.toString(); ou (int)n; assim só botar alguma logica para ver qual classe ele selecinou
        }
    }
}
