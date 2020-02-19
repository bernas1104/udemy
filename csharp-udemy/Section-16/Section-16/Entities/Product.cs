using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Product
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
