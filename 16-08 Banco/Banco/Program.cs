using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            Conta c2 = new Conta();
            int escolha;
            float quantia;
            while (true)
            {
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 - Consultar Saldo.");
                Console.WriteLine("2 - Depositar.");
                Console.WriteLine("3 - Sacar.");
                Console.WriteLine("4 - Transferir.");
                Console.WriteLine("-----");

                escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("-----");
                        Console.WriteLine("Você tem: {0} de saldo." ,c1.ConsultarSaldo());
                        Console.WriteLine("-----");
                        break;
                    case 2:
                        Console.WriteLine("-----");
                        Console.WriteLine("Quantos você deseja depositar?");
                       c1.Depositar(float.Parse(Console.ReadLine()));
                        Console.WriteLine("-----");
                        break;
                    case 3:
                        Console.WriteLine("-----");
                        Console.WriteLine("Quantos você deseja sacar?");
                        quantia = 0;
                        quantia = float.Parse(Console.ReadLine());
                        if (c1.Sacar(quantia) == true)
                        {
                            Console.WriteLine("Você sacou com sucesso: {0}.", quantia);
                        } else
                        {
                            Console.WriteLine("Você não tem saldo o suficiente.");
                        }
                        Console.WriteLine("-----");
                        break;
                    case 4:
                        Console.WriteLine("-----");
                        Console.WriteLine("Quantos você deseja transferir?");
                        quantia = 0;
                        quantia = float.Parse(Console.ReadLine());
                        if (c1.Transferir(c2,quantia) == true)
                        {
                            Console.WriteLine("Você transferiu com sucesso: {0}.", quantia);
                        }
                        else
                        {
                            Console.WriteLine("Você não tem saldo o suficiente.");
                        }
                        Console.WriteLine("-----");
                        break;


                        
                }

            }
        }
    }
}
