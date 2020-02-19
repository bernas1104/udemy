using System;
using System.Collections.Generic;
using System.Text;

namespace Section_10.Ex3
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double ImpostosPagos();
    }
}
