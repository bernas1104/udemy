using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Funcionario
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }
    }
}
