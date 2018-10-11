using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoRPG
{
    class Personagem
    {
        string nome;
        int dano;
        int vida;
        double experiencia;
        Classe.Classes classe;
        int nivel;
        int forca;
        int inteligencia;
        int destreza;
        Item[] inventario;
        Item maoDireita;
        Item maoEsquerda;

        public Personagem(string nome, int classe)
        {
            this.nome = nome;
            Classe c = new Classe();
            this.classe = c.selecionarClasseId(classe);

            switch (this.classe)
            {
                case Classe.Classes.Guerreiro:
                    forca = 4;
                    inteligencia = 2;
                    destreza = 1;
                    break;
                case Classe.Classes.Arqueiro:
                    forca = 2;
                    inteligencia = 3;
                    destreza = 3;
                    break;
                case Classe.Classes.Mago:
                    forca = 1;
                    inteligencia = 4;
                    destreza = 2;
                    break;
                case Classe.Classes.Ladino:
                    forca = 2;
                    inteligencia = 2;
                    destreza = 4;
                    break;
            }
            dano = 2;
            vida = 10;
            experiencia = 100;
            nivel = 1;
            inventario = new Item[4];
            maoDireita = new Item("Mão", "Sua mão direita.", 1);
            maoEsquerda = new Item("Mão", "Sua mão esquerda.", 1);
        }

        public Personagem(string nome)
        {
            this.nome = nome;
            dano = 2;
            vida = 10;
            experiencia = 100;
            nivel = 1;
            inventario = new Item[4];
            maoDireita = new Item("Mão", "Sua mão direita.", 1);
            maoEsquerda = new Item("Mão", "Sua mão esquerda.", 1);
        }

        public int atacarAlvo(Personagem personagem)
        {
            int danoCausado = 0;
            int danoMax = 0;
            Random rand = new Random();

            switch (classe)
            {
                case Classe.Classes.Guerreiro:
                    if (maoDireita.getDano() >= 1 && maoEsquerda.getDano() >= 1)
                    {
                        danoMax = maoDireita.getDano() + maoEsquerda.getDano() + dano;
                    }
                    else if (maoDireita.getDano() >= 1)
                    {
                        danoMax = maoEsquerda.getDano() + dano;
                    }
                    else if (maoEsquerda.getDano() >= 1)
                    {
                        danoMax = maoEsquerda.getDano() + dano;
                    }
                    else
                    {
                        danoCausado = dano;
                        personagem.receberDano(danoCausado);
                        break;
                    }
                    danoCausado = rand.Next(dano, danoMax);
                    personagem.receberDano(danoCausado);
                    break;
            }

            return danoCausado;
        }

        public void receberDano(int dano)
        {
            if (dano >= vida)
            {
                Console.WriteLine("{0} morreu!", nome);
            }
            else
            {
                vida -= dano;
            }
        }
    }
}
