using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rpg_do_prof
{
    class TodosOsObjetos
    {
        public static List<Item> item = new List<Item>();
        public static List<Item> armasIniciais = new List<Item>();
        public static List<SerVivo> inimigo = new List<SerVivo>();

        static TodosOsObjetos()
        {


            #region Inimigos
            //Inimigos
            inimigo.Add(new SerVivo(10, "Slime azul"));
            inimigo.Add(new SerVivo(10, "Slime roxo"));
            #endregion Inimigos

            #region Todos os Itens
            //Itens
            item.Add(new Item(1, 3, "Ordinaria Espada"));
            #endregion Todos os Itens

            #region Itens Iniciais
            //Itens do começo do jogo.
            armasIniciais.Add(new Item(1, 3, "Espada Ordinaria de Madeira"));
            armasIniciais.Add(new Item(2, 4, "Espada de Cobre enferrujada"));
            armasIniciais.Add(new Item(5,0,0,"Elixir de vida superior", "Um elixir de vida que pode curar qualquer doenças"));

            #endregion Itens Iniciais
        }
    }
}
