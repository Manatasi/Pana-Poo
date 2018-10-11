using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapa m = new Mapa(90, 50);
            Texto t = new Texto(m);
            Classe c = new Classe();

            t.adicionarTexto("Qual é o seu nome?");
            string nome = t.responderTexto(Console.ReadLine());
            t.adicionarTexto("Qual é a sua classe?");
            t.adicionarTexto(c.getNomeClasses());
            int classe = 0;
            do
            {
                try
                {
                    classe = Convert.ToInt32(Console.ReadLine());
                    if (c.selecionarClasse(classe) == "Informe um valor válido.")
                    {
                        throw new SystemException();
                    }
                    else
                    {
                        t.selecionarTexto(c.selecionarClasse(classe));
                    }
                }
                catch
                {
                    classe = 0;
                    t.adicionarTexto("Informe um valor válido");
                }
            } while (classe == 0);
            t.adicionarTexto("Parabéns! Aperte novamente alguma tecla para continuar a sua aventura!");
            Console.ReadKey();
            Console.Clear();

            Personagem heroi = new Personagem(nome, classe);
            Personagem inimigo1 = new Personagem("Slime");

            heroi.atacarAlvo(inimigo1);

            Console.ReadLine();
        }
    }
}
