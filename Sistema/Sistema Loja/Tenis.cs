using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Loja
{
    class Tenis : Produto
    {
        public Tenis(string nome, double preco, int codigo, int estoque)
            : base(nome, preco, codigo, estoque)
        {
        }
    }
}
