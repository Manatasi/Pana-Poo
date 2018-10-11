using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoRPG
{
    class Classe
    {
        public enum Classes
        {
            Guerreiro = 1,
            Arqueiro = 2,
            Mago = 3,
            Ladino = 4
        };


        public Classe()
        {

        }

        public Classes[] getNomeClasses()
        {
            Classes[] elementos = Enum.GetValues(typeof(Classes)) as Classes[];
            return elementos;
        }

        public string selecionarClasse(int i)
        {
            try
            {
                foreach (Classe.Classes n in getNomeClasses())
                {
                    if (i == (int)n)
                    {
                        return n.ToString();
                    }
                }

                return "Informe um valor válido.";
            }
            catch
            {
                return "Informe um valor válido.";
            }
        }

        public Classes selecionarClasseId(int classe)
        {
            Classes enu = Classes.Arqueiro;

            foreach (Classe.Classes n in getNomeClasses())
            {
                if (classe == (int)n)
                {
                    enu = n;
                }
            }
            return enu;
        }
    }
}
