using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rpg_do_prof
{
    class Heroi : SerVivo
    {
        List<Item> inventario = new List<Item>();
        Item armaPrincipal;
        double expParaEvoluir = 100;
        double expAtual = 0;
        string raca;

        public Heroi(int vida, string nome, string raca)
            : base(vida, nome)
        {
            this.raca = raca;
            Random r = new Random();
            int i = r.Next(0, TodosOsObjetos.armasIniciais.Count());
            armaPrincipal = TodosOsObjetos.armasIniciais[i];
            //           TodosOsObjetos.item.Find(x => x.nome == "Espada");
        }

        public string atacar(Inimigo alvo)
        {
            if (alvo.vida <= 0)
            {
                return alvo.nome + " já está morto.";
            }

            string mensagem = "";
            Random r = new Random();

            int danoCausado = r.Next(armaPrincipal.getDanoMin(), armaPrincipal.getDanoMax() + 1);
            alvo.vida -= danoCausado;

            mensagem = alvo.nome + " recebeu " + danoCausado + " de dano, da arma " + armaPrincipal.ToString() + ".\n";

            if (alvo.vida <= 0)
            {
                mensagem += alvo.nome + " morreu.";
                setExperiencia(alvo.getExpAoMatar());
            }
            else
            {
                mensagem += "Ficando com " + alvo.vida + " de vida restante.";
            }

            return mensagem;
        }

        public override void getInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Nome: {0} | ", nome);
            Console.Write("Vida: {0} | ", vida);
            Console.Write("Nível: {0} ", level);
            Console.WriteLine("Expiencia: {0}/{1} ", expAtual, expParaEvoluir);
            Console.ResetColor();
        }

        public string setExperiencia(double exp)
        {
            if (exp <= 0) return "";
            expAtual += exp;
            if (expAtual >= expParaEvoluir)
            {
                int levelAntigo = level;
                level += 1;
                expAtual = 0;
                expParaEvoluir += 100;
                return nome + " evoluiu de nível! " + " Do nível " + levelAntigo + " para o nível " + level;
            }
            return nome + " recebeu " + exp + " de experiencia.";
        }
    }
}
