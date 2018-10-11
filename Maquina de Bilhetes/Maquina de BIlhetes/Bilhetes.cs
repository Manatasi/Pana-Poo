using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_BIlhetes
{
    class Bilhetes
    {
        double Preco;
        int Bilhete;
        float QuantiaDinheiroGasto;
        public Bilhetes()
        {
            Preco = 4.7;
        }
        public int QuantosBilhetesPossoComprar(float QuantiaDinheiro)
        {
            QuantiaDinheiroGasto = QuantiaDinheiro;
            Bilhete = Convert.ToInt32(QuantiaDinheiro / Preco);
            return Bilhete;
        }
        public double TrocoRestante()
        {
            double troco;
            double precoParaComprar;
            precoParaComprar = Bilhete * Preco;
            troco =   QuantiaDinheiroGasto - precoParaComprar;
            return troco;
        }
    }
}
