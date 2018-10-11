using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgBacaninha
{
    class SerVivo
    {
        public string nome { get; private set; }
        public int dano { get; private set; }
        public int vidaAtual { get; private set; }
        public int vidaMaxima { get; private set; }
        public int nivel { get; private set; }
        public int forca { get; private set; }
        public int inteligencia { get; private set; }
        public int destreza { get; private set; }

        /*  public SerVivo(string nome, int classe)
          {
              this.nome = nome;
              Classes c = new Classes();
              this.classe = c.selecionarClasseId(classe);

              dano = 2;
              vida = 10;
              experiencia = 100;
              nivel = 1;
              inventario = new Item[4];
              maoDireita = new Item("Mão", "Sua mão direita.", 1);
              maoEsquerda = new Item("Mão", "Sua mão esquerda.", 1);
            
          }*/


        public SerVivo(string nome) //construtor para o jogador
        {
            this.nome = nome;
            dano = 2;
            vidaMaxima = 10;
            vidaAtual = 10;
            nivel = 1;
            calcularAtributos();
        }
        public SerVivo(string nome, int dano, int vida, int nivel) //COnstrutor para o inimigo
        {
            this.nome = nome;
            this.dano = dano;
            this.vidaMaxima = vida;
            this.vidaAtual = vida;
            this.nivel = nivel;
            calcularAtributos();
        }

        public void receberDano(int dano, SerVivo alvo)
        {
            //fazer a logica do receber dano
        }

        private void calcularAtributos()
        {
            Random r = new Random();
            forca = r.Next(1, 11);
            inteligencia = r.Next(1, 11);
            destreza = r.Next(1, 11);
        }
        
        public void batalhar(SerVivo alvo)
        {
            while (verificarSeEstaVivo() == true && alvo.verificarSeEstaVivo() == true)
            {
                Console.WriteLine("Você pode atacar, usar habilidade e fugir");
                Console.WriteLine("Qual você escolhe?");
                Console.ReadLine();

                //terminar logica da batalha
            } 
            if(verificarSeEstaVivo() == false)
            {
                Console.WriteLine("Você morreu!");
            } else
            {
                Console.WriteLine("Você matou o {0}", alvo.nome);
            }
            
        }

        public bool verificarSeEstaVivo() // falso para morto, //true para vivo
        {
            if (vidaAtual <= 0)
            {
                return false; // morto
            }
            return true; // vivo
        }
    }
}
