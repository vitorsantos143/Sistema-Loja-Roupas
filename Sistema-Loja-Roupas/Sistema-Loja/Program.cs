using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Loja
{
    internal class Program
    {
        static Cliente cliente = new Cliente();
        static Produto[] carrinho = new Produto[20];
        static int[] quantidadeCarrinho = new int[10];
        static int contCarrinho = 0;

        static void Main(string[] args)
        {
            string opcao = "";

            while (opcao != "Q")
            {
                Console.WriteLine("\nBem Vindo a loja de roupas");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Visualizar Produtos");
                Console.WriteLine("3 - Ver Carrinho");
                Console.WriteLine("4 - Adicionar Compra");
                Console.WriteLine("5 - Finalizar Compra");
                Console.WriteLine("Q - Sair");

                opcao = Console.ReadLine().ToUpper();
                switch (opcao)
                {
                    case "1":
                        CadastroCliente();
                        break;

                    case "2":
                        Produtos();
                        break;

                    case "3":

                        MostrarCarrinho();
                        break;

                    case "4":
                        Compra();
                        break;
                    case "5":
                        ComprarCarrinho();
                        break;
                    case "Q":
                        Console.WriteLine("Obrigado por usar o programa!");
                        break;


                }
            }
        }

        static void CadastroCliente()
        {
            Console.Write("Nome: ");
            cliente.nome = Console.ReadLine();

            Console.Write("CPF: ");
            cliente.cpf = Console.ReadLine();

            Console.Write("RG: ");
            cliente.rg = Console.ReadLine();

            Console.WriteLine("Cliente cadastrado!");


        }

        static void Produtos()
        {
            Console.WriteLine("\n1 - Camisa - R$60");
            Console.WriteLine("2 - Camiseta - R$55");
            Console.WriteLine("3 - Camisa Manga Longa - R$60");
            Console.WriteLine("4 - Short - R$45");
            Console.WriteLine("5 - Calça - R$95");
            Console.WriteLine("6 - Blusa - R$180");
            Console.Write("");

        }

        static void MostrarCarrinho()
        {
            decimal total = 0;

            Console.WriteLine("\nCARRINHO");

            for (int i = 0; i < contCarrinho; i++)
            {
                Console.WriteLine(
                    carrinho[i].nome +
                    " Quantidade " + quantidadeCarrinho[i] +
                    " - R$" +
                    carrinho[i].preco);

                total += carrinho[i].preco * quantidadeCarrinho[i];

            }

            Console.WriteLine("Total: R$" + total);
        }
        static void Compra()
        {
            int produto = 0;

            while (produto < 1 || produto > 6)
            {
                Console.WriteLine("1 - Camisa - R$60");
                Console.WriteLine("2 - Camiseta - R$55");
                Console.WriteLine("3 - Camisa Manga Longa - R$60");
                Console.WriteLine("4 - Short - R$45");
                Console.WriteLine("5 - Calça - R$95");
                Console.WriteLine("6 - Blusa - R$180");

                Console.Write("Escolha um produto: ");
                produto = int.Parse(Console.ReadLine());

                if (produto < 1 || produto > 6)
                {
                    Console.WriteLine("Produto inválido!");
                }
            }

            Produto p = new Produto();

            switch (produto)
            {
                case 1:
                    p.nome = "Camisa";
                    p.preco = 60;
                    break;

                case 2:
                    p.nome = "Camiseta";
                    p.preco = 55;
                    break;

                case 3:
                    p.nome = "Camisa Manga Longa";
                    p.preco = 60;
                    break;

                case 4:
                    p.nome = "Short";
                    p.preco = 45;
                    break;

                case 5:
                    p.nome = "Calça";
                    p.preco = 95;
                    break;

                case 6:
                    p.nome = "Blusa";
                    p.preco = 180;
                    break;
            }
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            carrinho[contCarrinho] = p;
            quantidadeCarrinho[contCarrinho] = quantidade;

            contCarrinho++;

            Console.WriteLine("Produto adicionado ao carrinho!");

        }
        static void ComprarCarrinho()
        {
            decimal total = 0;

            for (int i = 0; i < contCarrinho; i++)
            {
                total += carrinho[i].preco * quantidadeCarrinho[i];
            }

            Console.WriteLine("Total da compra: R$" + total);

            Console.Write("Quanto dinheiro você tem? ");
            decimal saldo = decimal.Parse(Console.ReadLine());

            if (saldo >= total)
            {
                saldo = saldo - total;

                Console.WriteLine("Compra realizada!");
                Console.WriteLine("Saldo restante: R$" + saldo);

                contCarrinho = 0;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
                Console.WriteLine("Faltam R$" + (total - saldo));
            }
        }
    }
}

