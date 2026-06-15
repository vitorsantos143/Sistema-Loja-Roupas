using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Loja
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Codigo { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome, double preco, int codigo, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Codigo = codigo;
            Estoque = estoque;
        }
    }
}
    
