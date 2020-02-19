using System;
using System.Collections.Generic;
using System.Text;

namespace Section_10.Ex3
{
    public class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double ImpostosPagos()
        {
            if(RendaAnual < 20000.00)
            {
                return GastoSaude == 0 ? RendaAnual * 0.15 : ((RendaAnual * 0.15) - (GastoSaude * 0.5));
            } else
            {
                return GastoSaude == 0 ? RendaAnual * 0.25 : ((RendaAnual * 0.25) - (GastoSaude * 0.5));
            }
        }
    }
}
