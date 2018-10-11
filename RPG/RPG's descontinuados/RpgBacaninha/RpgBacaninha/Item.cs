using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgBacaninha
{
    class Item
    {
        int dano;
        int quantidade;
        string nome;
        string descricao;

        public Item(string nome, string descricao, int dano, int quantidade)//construtor para o inventario do jogador
        {
            this.nome = nome;
            this.descricao = descricao;
            this.dano = dano;
            this.quantidade = quantidade;
        }

        public Item(string nome, int dano)//construtor para o inimigo
        {
            this.nome = nome;
            descricao = "Um item estranho.";
            this.dano = dano;
            quantidade = 1;
        }

        public Item(string nome, string descricao, int dano) //construtor para 1 item só, para o inventario do jogador
        {
            this.nome = nome;
            this.descricao = descricao;
            this.dano = dano;
            quantidade = 1;
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
            return true; //volta um true falando que usou o item
        }
        public void adicionarQuantidade(int quantidade)
        {
            this.quantidade += quantidade;
        }
    }
}
