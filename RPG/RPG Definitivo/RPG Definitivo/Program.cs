using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Definitivo
{
    class Program
    {
        public static bool lutando = true;

        static void Main(string[] args)
        {
            while (true)
            {
                string nome = Pergunta.RetornoTexto("Qual o seu nome?");
                string raca = Pergunta.RetornoTexto("Qual a sua raça?");
                Heroi h = new Heroi(30, nome, raca);

                Random r = new Random();
                int i = r.Next(0, TodosOsObjetos.inimigo.Count());
                Inimigo s = TodosOsObjetos.inimigo[i];

                while (true)
                {
                    Console.Clear();

                    int escolha = -1;
                    do
                    {
                        s.getInfo();
                        h.getInfo();
                        Console.WriteLine(Menu.Luta());
                        try
                        {
                            escolha = Pergunta.RetornoInt("Indique o número para executar a ação.");
                        }
                        catch { }

                        Console.Clear();
                        switch (escolha)
                        {
                            case 0:
                                Console.WriteLine(h.atacar(s));
                                break;
                            case 1:
                                break;
                        }

                        Console.WriteLine();
                    } while (lutando);

                    Console.ReadLine();
                }
            }
        }
    }
}
