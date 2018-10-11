using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Definitivo
{
    class SerVivo
    {
        public int vidaAtual;
        public int vidaMax;
        public string nome;
        public int level;

        public SerVivo(int vida, string nome)
        {
            vidaAtual = vida;
            vidaMax = vida;
            this.nome = nome;
            level = 1;
        }

        public SerVivo(int vida, string nome, int level)
        {
            vidaAtual = vida;
            vidaMax = vida;
            this.nome = nome;
            this.level = level;
        }

        public virtual string atacar(int danoMin, int danoMax, SerVivo alvo)
        {
            if (alvo.vidaAtual <= 0)
            {
                return alvo.nome + " já está morto.";
            }
            string mensagem = "";
            Random r = new Random();

            int danoCausado = r.Next(danoMin, danoMax + 1);
            alvo.vidaAtual -= danoCausado;

            mensagem = alvo.nome + " recebeu " + danoCausado + " de dano. ";

            if (alvo.vidaAtual <= 0)
            {
                mensagem += alvo.nome + " morreu.";
            }
            else
            {
                mensagem += "Ficando com " + alvo.vidaAtual + " de vida restante.";
            }

            return mensagem;
        }

        public virtual void getInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Nome: {0} | ", nome);
            Console.Write("Vida: {0} | ", vidaAtual);
            Console.WriteLine("Nível: {0} ", level);
            Console.ResetColor();
        }
    }
}
