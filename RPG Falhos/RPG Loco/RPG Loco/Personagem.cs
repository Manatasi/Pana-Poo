using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Loco
{
    class Personagem
    {
        string Nome;
        string Raca;

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }
        
        public string getNome()
        {
            return Nome;
        }
    }
}
