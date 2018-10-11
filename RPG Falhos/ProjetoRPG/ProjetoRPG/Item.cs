using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoRPG
{
    class Item
    {
        int dano;
        int quantidade;
        string nome;
        string descricao;

        public Item(string nome, string descricao, int dano, int quantidade)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.dano = dano;
            this.quantidade = quantidade;
        }

        public Item(string nome, int dano)
        {
            this.nome = nome;
            this.descricao = "Um item estranho.";
            this.dano = dano;
            this.quantidade = 1;
        }

        public Item(string nome, string descricao, int dano)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.dano = dano;
            this.quantidade = 1;
        }

        public int getDano()
        {
            return dano;
        }

        public bool usarItem(int quantidade)
        {
            if (quantidade > this.quantidade)
            {
                return false;
            }
            else
            {
                this.quantidade -= quantidade;
            }
            return true;
        }
        public void adicionarQuantidade(int quantidade)

        {
            this.quantidade =+ quantidade;
        }
    }
}
