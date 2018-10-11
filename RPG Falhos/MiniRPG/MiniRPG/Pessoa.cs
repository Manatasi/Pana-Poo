using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniRPG
{
    class Pessoa
    {
        double vida;
        double dano;
        string nome;
        Classe classe;

        public Pessoa(double vida, double dano, string nome, string classe)
        {
            this.vida = vida;
            this.dano = dano;
            this.nome = nome;
            this.classe = new Classe(classe);
        }


        public void getStatus(int largura, int altura)
        {
        }
    }
}
