using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Loja
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Cliente[] clientes = new Cliente[10];

            Console.WriteLine("=== CADASTRO DO CLIENTE ===");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            clientes[0] = new Cliente(nome, endereco, cpf, email);

            
            Produto[] catalogo =
            {
                new Blusa("Blusa Moletom", 120.00, 1, 10),
                new Camisa("Camisa Polo", 80.00, 2, 15),
                new Tenis("Tênis Esportivo", 250.00, 3, 8)
            };

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n=== CATÁLOGO ===");

                for (int i = 0; i < catalogo.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {catalogo[i].Nome} | R$ {catalogo[i].Preco:F2}");
                }

                Console.Write("\nEscolha um produto: ");
                int opcao = int.Parse(Console.ReadLine());

                Produto produtoEscolhido = null;

                switch (opcao)
                {
                    case 1:
                        produtoEscolhido = catalogo[0];
                        break;

                    case 2:
                        produtoEscolhido = catalogo[1];
                        break;

                    case 3:
                        produtoEscolhido = catalogo[2];
                        break;

                    default:
                        Console.WriteLine("Produto inválido.");
                        continue;
                }

                Console.WriteLine("\n=== RESUMO DA COMPRA ===");
                Console.WriteLine($"Cliente: {clientes[0].Nome}");
                Console.WriteLine($"Produto: {produtoEscolhido.Nome}");
                Console.WriteLine($"Preço: R$ {produtoEscolhido.Preco:F2}");

                Console.WriteLine("\nMétodos de pagamento");
                Console.WriteLine("1 - Dinheiro");
                Console.WriteLine("2 - Cartão");
                Console.WriteLine("3 - Pix");

                Console.Write("Escolha: ");
                int pag = int.Parse(Console.ReadLine());

                string metodo = "";

                switch (pag)
                {
                    case 1:
                        metodo = "Dinheiro";
                        break;

                    case 2:
                        metodo = "Cartão";
                        break;

                    case 3:
                        metodo = "Pix";
                        break;

                    default:
                        metodo = "Não informado";
                        break;
                }

                Pagamento pagamento =
                    new Pagamento(metodo, produtoEscolhido.Preco);

                pagamento.ExibirPagamento();

                Console.Write("\nDeseja comprar outro produto? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta != "S")
                {
                    continuar = false;
                }
            }

            Console.WriteLine("\nCompra encerrada.");
        }
    }
}