using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rpg_do_prof
{
    class Program
    {
        public enum Escolha
        {
            Atacar = 0,
            Fugir = 1,
            Ver_inventário = 2,
            Ver_habilidades = 3
        }

        public static bool lutando = true;

        static void Main(string[] args)
        {
            while (true)
            {

                string nome = Pergunta.RetornoTexto("Qual o seu nome?");
                string raca = Pergunta.RetornoTexto("Qual a sua raça?");
                Heroi h = new Heroi(30, nome, raca);

                while (true)
                {
                    Console.Clear();

                    string mensagem = "";
                    Escolha[] elementos = Enum.GetValues(typeof(Escolha)) as Escolha[];
                    foreach (Escolha n in elementos)
                    {
                        int valor = (int)n;
                        string texto = n.ToString();
                        mensagem += valor + " => " + texto + "\n";
                        mensagem = mensagem.Replace('_', ' ');
                    }

                    int escolha = 0;
                    do
                    {
                        s.getInfo();
                        h.getInfo();  
                        Console.WriteLine(mensagem);
                        escolha = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (escolha)
                        {
                            case 0:
                                Console.WriteLine("Você escolheu atacar.");
                                Console.WriteLine(h.atacar(s));
                                break;
                            case 1:
                                Console.WriteLine("Você escolheu fugir.");
                                break;
                        }

                        Console.WriteLine();
                    } while (lutando);

                    Console.ReadLine();
                }
                Random r = new Random();
                Console.ReadLine();
            }
        }
    }
}
