using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_BIlhetes
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilhetes b1 = new Bilhetes();
            float QuantiaBilhetes;
            QuantiaBilhetes = float.Parse(Console.ReadLine());
            Console.WriteLine("Você pode comprar {0} bilhetes.", b1.QuantosBilhetesPossoComprar(QuantiaBilhetes));
            Console.WriteLine("Você ficara com {0} reais de troco.", string.Format("{0:C}",  b1.TrocoRestante()));
            Console.ReadKey();
        }
    }
}
