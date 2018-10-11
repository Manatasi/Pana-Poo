using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgBacaninha
{
    class Habilidade
    {
        public string nome { get; private set; }
        public int nivelRequerido { get; private set; }
        public string descricao { get; private set; }

        public int pontosDeHabilidadeRequerido { get; private set; }

        public Habilidade(string nome, int nivelRequerido, int pontosDeHabilidadeRequerido, string descricao)
        {
            this.nome = nome;
            this.nivelRequerido = nivelRequerido;
            this.descricao = descricao;
            this.pontosDeHabilidadeRequerido = pontosDeHabilidadeRequerido;
        }
    }
}
