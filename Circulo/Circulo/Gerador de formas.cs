using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class Gerador_de_formas
    {
        int numeros;
        public Gerador_de_formas(int quantiaDeLados)
        {
            numeros  = quantiaDeLados;
        }

        public int quantosLadosTem()
        {
            return numeros;
        }
    }
}
