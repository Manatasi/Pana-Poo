using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Definitivo
{
   static class TodosOsObjetos
    {
        public static List<Item> item = new List<Item>();
        public static List<Item> armasIniciais = new List<Item>();
        public static List<Inimigo> inimigo = new List<Inimigo>();

        static TodosOsObjetos()
        {


            #region Inimigos
            //Inimigos
            inimigo.Add(new Inimigo(100,20, "Slime azul", 2));
            inimigo.Add(new Inimigo(50,10, "Slime roxo"));
            inimigo.Add(new Inimigo(200, 15, "Goblin"));
            #endregion Inimigos

            #region Todos os Itens
            //Itens
            item.Add(new Item(1, 3, "Ordinaria Espada"));
            #endregion Todos os Itens

            #region Itens Iniciais
            //Itens do começo do jogo.
            armasIniciais.Add(new Item(1, 3, "Espada Ordinaria de Madeira"));
            armasIniciais.Add(new Item(1, 4, "Espada de Cobre enferrujada"));
            armasIniciais.Add(new Item(1, 3, "Arco Curto de Madeira Podre"));
            #endregion Itens Iniciais
        }
    }
}
