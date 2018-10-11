using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgBacaninha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Habilidade> habilidades = new List<Habilidade> {
                new Habilidade("Avaliar",1,100,"Habilidade avaliativa."),
                new Habilidade("Olho demoniaco", 8, 100, "Aplica debuff de vida."),
            };
            TextoOpcoes txt = new TextoOpcoes();
            
            Historia("Bem-vindo ao mundo Akaixa!");
            Historia("Logando...");
            Historia("Logado.");
            //Historia("Qual o seu nome?");
            txt.fraseNomeJogador();

            Jogador j = new Jogador(Console.ReadLine());

            Historia("Reiniciando...");
            Console.Clear();
            Historia(".");
            Historia("..");
            Historia("...");
            HistoriaPersonagem("'Onde estou??'");
            HistoriaPersonagem("'Por que está tão escuro aqui??'");
           // Historia("Nova habilidade disponível: {0}", h[0].nome);
            txt.novaHabilidade(habilidades[0]);
            txt.escolherHabilidade(habilidades[0]);
            

            Console.ReadLine();

            /*
            j.getEstatisticas();
            Inimigo i = new Inimigo("Goblin", 3, 6, 2);
            
            

            //teste texto de batalha

            txt.textoAtaqueDoInimigoNoHeroi(i, j, 20);
            //batalha real agr
            j.batalhar(i);
             * */
        }




        protected static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        protected static void HistoriaPersonagem(string texto, params object[] objetos)
        {
            texto = texto.Replace("'", '"'.ToString());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(texto, objetos);
            int top = Console.CursorTop;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Aperte qualquer botão para continuar..");
            Console.ResetColor();
            Console.ReadKey(true);
            WriteAt("                                      ", 0, top);
            Console.SetCursorPosition(0, top);
        }

        protected static void Historia(string texto, params object[] objetos)
        {
            texto = texto.Replace("'", '"'.ToString());
            Console.WriteLine(texto, objetos);
            int top = Console.CursorTop;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Aperte qualquer botão para continuar..");
            Console.ResetColor();
            Console.ReadKey(true);
            WriteAt("                                      ", 0, top);
            Console.SetCursorPosition(0, top);
        }

        public static void Historia()
        {
            int top = Console.CursorTop;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Aperte qualquer botão para continuar..");
            Console.ResetColor();
            Console.ReadKey(true);
            WriteAt("                                      ", 0, top);
            Console.SetCursorPosition(0, top);
        }
    }
}
