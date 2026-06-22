using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Loja
{
    internal class Cliente
    {
        public string cpf;
        public string rg;
        public string nome;

        public void Exibircliente()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("RG: " + rg);
        }
    }
}
