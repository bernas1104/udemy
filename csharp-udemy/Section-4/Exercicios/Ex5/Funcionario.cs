using System;
namespace Ex5
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public Funcionario()
        {
        }

        public void AumentarSalario(double percent)
        {
            SalarioBruto *= (1.0 + (percent / 100.00));
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2");
        }
    }
}
