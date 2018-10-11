using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgBacaninha
{
    class TextoOpcoes
    {
        ConsoleColor corInimigo;
        ConsoleColor corAliado;
        ConsoleColor corJogador;
        ConsoleColor corItem;
        ConsoleColor corHabilidade;
        ConsoleColor corAtaque;
        ConsoleColor corMapa;
        ConsoleColor corPontosDeHabilidade;

        public TextoOpcoes(ConsoleColor corInimigo,
                            ConsoleColor corAliado,
                            ConsoleColor corJogador,
                            ConsoleColor corItem,
                            ConsoleColor corHabilidade,
                            ConsoleColor corAtaque,
                            ConsoleColor corMapa)
        {
            this.corInimigo = corInimigo;
            this.corAliado = corAliado;
            this.corJogador = corJogador;
            this.corItem = corItem;
            this.corHabilidade = corHabilidade;
            this.corAtaque = corAtaque;
            this.corMapa = corMapa;
        }

        public TextoOpcoes()
        {
            this.corInimigo = ConsoleColor.Red;
            this.corAliado = ConsoleColor.Green;
            this.corJogador = ConsoleColor.DarkGreen;
            this.corItem = ConsoleColor.Magenta;
            this.corHabilidade = ConsoleColor.DarkRed;
            this.corAtaque = ConsoleColor.DarkMagenta;
            this.corMapa = ConsoleColor.Cyan;
            corPontosDeHabilidade = ConsoleColor.DarkYellow;
        }

        public void fraseColorida(string frase, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(frase);
            Console.ResetColor();

        }
        public void fraseColorida(int frase, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(frase);
            Console.ResetColor();
        }
        public void fraseColorida(double frase, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(frase);
            Console.ResetColor();
        }
        public void fraseNomeJogador()
        {
            Console.Write("Qual o seu ");
            fraseColorida("nome?", corJogador);
            Console.ResetColor();
            Console.WriteLine();
            Program.Historia();
        }

        public void textoAtaqueDoInimigoNoHeroi(SerVivo Inimigo, SerVivo Heroi, double danoCausado)
        {
            fraseColorida(Inimigo.nome, corInimigo);
            Console.Write(" causou ");
            fraseColorida(danoCausado, corAtaque);
            Console.Write(" de dano no ");
            fraseColorida(Heroi.nome + ".", corJogador);
            Console.WriteLine();
        }

        public void novaHabilidade(Habilidade habilidade)
        {
            Console.Write("Nova habilidade disponível: ");
            fraseColorida(habilidade.nome, corHabilidade);
            Console.WriteLine();
            Program.Historia();
        }

        public void escolherHabilidade(Habilidade habilidade)
        {
            Console.Write("Você deseja gastar ");
            fraseColorida(habilidade.pontosDeHabilidadeRequerido, corPontosDeHabilidade);
            Console.Write(" pontos na habilidade ");
            fraseColorida(habilidade.nome, corHabilidade);
            Console.Write("?");
            Console.WriteLine();
        }

        /*public int escolhaSimOuNao()
        {

        }
        */
    }
}
