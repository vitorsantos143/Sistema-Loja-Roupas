using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Camisas cam = new Camisas();
            Shorts sht = new Shorts();
            Tenis shoes = new Tenis();

            while (op != 0)
            {
                Console.WriteLine("1. Comprar Camisas");
                Console.WriteLine("2. Comprar Shorts");
                Console.WriteLine("3. Comprar Tenis");
                Console.WriteLine("0. Sair");

                Console.WriteLine("\n Escolha uma opção:");

                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: 
                        cam
                }
                }
        }
    }
}
