using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
   class Conta
    {
        float Dinheiro;
        public Conta()
        {
            Dinheiro = 50;
        }

        public float ConsultarSaldo()
        {
            return Dinheiro;
        }

        public void Depositar(float QuantiaDinheiro)
        {
            Dinheiro = Dinheiro + QuantiaDinheiro;
        }

        public bool Sacar()
        {
            if (Dinheiro >= 50)
            {
                Dinheiro = Dinheiro - 50;
                return true;
            }
            return false;
        }

        public bool Sacar(float QuantiaDinheiro)
        {
            if (Dinheiro >= QuantiaDinheiro)
            {
                Dinheiro = Dinheiro - QuantiaDinheiro;
                return true;
            }
            return false;
        }

        public bool Transferir(Conta conta)
        {
            if (Dinheiro >= 50)
            {
                Dinheiro = Dinheiro - 50;
                conta.Depositar(50);
                return true;
            }
            return false;
        }

        public bool Transferir(Conta conta, float QuantiaDinheiro)
        {
            if (Dinheiro >= QuantiaDinheiro)
            {
                Dinheiro = Dinheiro - QuantiaDinheiro;
                conta.Depositar(QuantiaDinheiro);
                return true;
            }
            return false;
        }
    }
}
