using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoRPG
{
    class Texto
    {
        List<string> lista;
        Mapa m;

        public Texto(Mapa mapa)
        {
            m = mapa;
            lista = new List<string>();
        }

        public void adicionarTexto(string texto)
        {
            lista.Add(texto);
            verificaTamanho();
            atualizarConsole();
        }

        public void adicionarTexto(Classe.Classes[] texto)
        {
            lista.Add("Classes disponíveis:");
            foreach (Classe.Classes n in texto)
            {
                int valor = (int)n;
                lista.Add(valor +" -> " + n.ToString());
            }
            verificaTamanho();
            atualizarConsole();
        }

        public string selecionarTexto(string texto)
        {
            lista.Add("Você selecionou: " + texto);
            verificaTamanho();
            atualizarConsole();
            return texto;
        }

        public string responderTexto(string texto)
        {
            lista.Add("Você respondeu: " + texto);
            verificaTamanho();
            atualizarConsole();
            return texto;
        }

        public void atualizarConsole()
        {
            Console.Clear();
            foreach (var textos in lista)
            {
                Console.WriteLine(textos);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < m.getX(); i++)
            {
                Console.WriteLine("█");
                Console.SetCursorPosition(i, lista.Count());
            }
            Console.SetCursorPosition(0, lista.Count() + 1);
            Console.ResetColor();
        }

        public void verificaTamanho()
        {
            while (lista.Count > m.getY() - 2)
            {
                lista.RemoveAt(0);
            }

        }

        public void fraseColorida(string texto,ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(texto );
        }
    }
}
