using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rpg_do_prof
{
    public class Item
    {
        int quantidade;
        int danoMin;
        int danoMax;
        string nome;
        string descricao;

        public Item(int quantidade, int danoMin, int danoMax, string nome, string descricao)
        {
            this.quantidade = quantidade;
            this.danoMax = danoMax;
            this.danoMin = danoMin;
            this.nome = nome;
            this.descricao = descricao;
        }

        public Item(int quantidade, int danoMax, string nome)
        {
            this.quantidade = quantidade;
            this.danoMax = danoMax;
            this.nome = nome;
            descricao = "Um item qualquer.";
            danoMin = Convert.ToInt32(danoMax / 2);
        }

        public override string ToString()
        {
            return nome;
        }

        public int getDanoMin()
        {
            return danoMin;
        }

        public int getDanoMax()
        {
            return danoMax;
        }
    }
}
