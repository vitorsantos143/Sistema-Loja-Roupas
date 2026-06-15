using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Loja
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string endereco, string cpf, string email)
        {
            Nome = nome;
            Endereco = endereco;
            CPF = cpf;
            Email = email;
        }
    }
}
