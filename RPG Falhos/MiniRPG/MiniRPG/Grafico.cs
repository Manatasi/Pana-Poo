using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniRPG
{
    class Grafico
    {
        string separador = "█";
        int larguraTela;
        int alturaTela;

        public Grafico(int larguraTela, int alturaTela)
        {
            this.larguraTela = larguraTela;
            this.alturaTela = alturaTela;
        }

        public void gerarQuadrado(int larguraPosicao, int alturaPosicao, int tamanho)
        {
            if (larguraPosicao > larguraTela)
            {
                Console.WriteLine("Largura da tela inferior a posição dada.");
                return;
            }

            if (alturaPosicao > alturaTela)
            {
                Console.WriteLine("Altura da tela infeior a posição dada.");
                return;
            }

            if (alturaTela < alturaPosicao + tamanho + 1)
            {
                Console.WriteLine("O tamanho passara do tamanho da tela.");
                return;
            }

            if (larguraTela < larguraPosicao + tamanho + 1)
            {
                Console.WriteLine("O tamanho passara do tamanho da tela.");
                return;
            }
            int x = larguraPosicao;
            int y = alturaPosicao;

            for (int i = 0; i < tamanho; i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.WriteLine(separador);
            }
            for (int i = 0; i < tamanho; i++)
            {
                Console.SetCursorPosition(x++, y);
                Console.WriteLine(separador);
            }
            for (int i = 0; i < tamanho; i++)
            {
                Console.SetCursorPosition(x, y--);
                Console.WriteLine(separador);
            }
            for (int i = 0; i < tamanho; i++)
            {
                Console.SetCursorPosition(x--, y);
                Console.WriteLine(separador);
            }
        }

        public void gerarForma(int larguraPosicao, int alturaPosicao, int tamanhoLargura, int tamanhoAltura, ConsoleColor cor, List<string> dados)
        {
            if (larguraPosicao > larguraTela)
            {
                Console.WriteLine("Largura da tela inferior a posição dada.");
                return;
            }

            if (alturaPosicao > alturaTela)
            {
                Console.WriteLine("Altura da tela infeior a posição dada.");
                return;
            }

            if (alturaTela < alturaPosicao + tamanhoAltura + 1)
            {
                Console.WriteLine("O tamanho passara do tamanho da tela.");
                return;
            }

            if (larguraTela < larguraPosicao + tamanhoLargura + 1)
            {
                Console.WriteLine("O tamanho passara do tamanho da tela.");
                return;
            }
            int x = larguraPosicao;
            int y = alturaPosicao;
            Console.ForegroundColor = cor;

            for (int i = 0; i < tamanhoAltura; i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.WriteLine(separador);
            }
            for (int i = 0; i < tamanhoLargura; i++)
            {
                Console.SetCursorPosition(x++, y);
                Console.WriteLine(separador);
            }
            for (int i = 0; i < tamanhoAltura; i++)
            {
                Console.SetCursorPosition(x, y--);
                Console.WriteLine(separador);
            }
            x = larguraPosicao + 1;
            for (int i = 0; i < tamanhoLargura; i++)
            {
                Console.SetCursorPosition(x++, y);
                Console.WriteLine(separador);
            }

            Console.ForegroundColor = ConsoleColor.White;
            x = larguraPosicao;
            y = alturaPosicao;

            adicionarDadosForma(tamanhoAltura, dados);

            foreach (var elementos in dados)
            {
                Console.SetCursorPosition(x + 1, y + 1);
                Console.WriteLine(elementos);                
                y++;
            }
        }

        public void adicionarDadosForma(int tamanho,List<string> dados)
        {
            while(dados.Count > tamanho -1)
            {
                dados.RemoveAt(0);
            }
        }
    }
}
