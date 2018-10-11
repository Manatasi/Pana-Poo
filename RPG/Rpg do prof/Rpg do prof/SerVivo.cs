using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rpg_do_prof
{
    class SerVivo
    {
        public int vida;
        public string nome;
        public int level;

        public SerVivo(int vida, string nome)
        {
            this.vida = vida;
            this.nome = nome;
            level = 1;
        }

        public SerVivo(int vida, string nome, int level)
        {
            this.vida = vida;
            this.nome = nome;
            this.level = level;
        }

        public virtual string atacar(int danoMin, int danoMax, SerVivo alvo)
        {
            if (alvo.vida <= 0)
            {
                return alvo.nome + " já está morto.";
            }
            string mensagem = "";
            Random r = new Random();

            int danoCausado = r.Next(danoMin, danoMax + 1);
            alvo.vida -= danoCausado;

            mensagem = alvo.nome + " recebeu " + danoCausado + " de dano. ";

            if (alvo.vida <= 0)
            {
                mensagem += alvo.nome + " morreu.";
            }
            else
            {
                mensagem += "Ficando com " + alvo.vida + " de vida restante.";
            }

            return mensagem;
        }

        public virtual void getInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Nome: {0} | ", nome);
            Console.Write("Vida: {0} | ", vida);
            Console.WriteLine("Nível: {0} ", level);
            Console.ResetColor();
        }
    }
}
