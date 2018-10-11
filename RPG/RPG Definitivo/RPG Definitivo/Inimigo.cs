using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Definitivo
{
    class Inimigo : SerVivo
    {
        double expGanhaAoMatar;

        public Inimigo(double expGanhaAoMatar, int vida, string nome, int level)
            : base(vida, nome, level)
        {
            this.expGanhaAoMatar = expGanhaAoMatar;
        }

        public Inimigo(double expGanhaAoMatar, int vida, string nome)
            : base(vida, nome)
        {
            this.expGanhaAoMatar = expGanhaAoMatar;
        }

        public double getExpAoMatar()
        {
            return expGanhaAoMatar;
        }
    }
}
