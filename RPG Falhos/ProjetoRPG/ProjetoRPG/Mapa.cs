using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoRPG
{
    class Mapa
    {
       static int x;
       static int y;
       private int p;
       private int p_2;
         public Mapa(int largura, int altura)
        {
            x = largura;
            y = altura;
            Console.SetWindowSize(x, y);
        }

        public int getY()
        {
            return y;
        }

        public int getX()
        {
            return x;
        }
    }
}
