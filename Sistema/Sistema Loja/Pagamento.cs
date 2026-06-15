using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Loja
{
    class Pagamento
    {
        public string Metodo { get; set; }
        public double Valor { get; set; }

        public Pagamento(string metodo, double valor)
        {
            Metodo = metodo;
            Valor = valor;
        }

        public void ExibirPagamento()
        {
            Console.WriteLine($"\nMétodo de Pagamento: {Metodo}");
            Console.WriteLine($"Valor Total: R$ {Valor:F2}");
        }
    }
}
