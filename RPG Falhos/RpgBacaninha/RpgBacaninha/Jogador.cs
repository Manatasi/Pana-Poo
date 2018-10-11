using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgBacaninha
{
    class Jogador : SerVivo
    {
        Item[] inventario; //Array de itens
        List<Habilidade> habilidades;
        //falta colocar classe agora
        public Jogador(string nome)
            : base(nome)
        {
            inventario = new Item[4]; // Cabe 5 item; 0 também conta
        }

        public void getEstatisticas() //Mostra o status do jogador, não coloquei na classe SerVivo, por que não vai mostrar o os atributos do inimigo. e nem o inventario. vou botar tudo em 1 só
        {
            Console.WriteLine("Vida: {0}/{1}", base.vidaAtual, base.vidaMaxima);
            Console.WriteLine("Nível {0}", base.nivel);
            Console.WriteLine("Dano {0}", base.dano);
        }

        public void setHabilidade(Habilidade habilidade)
        {
            habilidades.Add(habilidade);
        }

        
    }
}
