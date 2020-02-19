using System;
using System.Collections.Generic;
using System.Text;

namespace Section_10.Ex3
{
    public class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double ImpostosPagos()
        {
            if(NumeroFuncionarios <= 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }
    }
}
