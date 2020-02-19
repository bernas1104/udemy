using System;
namespace Ex2
{
    public class ContaCorrente
    {
        public int NumeroConta { private set; get; }
        private string _titular;
        public string Titular { get { return _titular; } set
            {
                if (value != null && value.Length >= 3)
                    _titular = value;
            }
        }
        public double Saldo { set; get; }
        
        public ContaCorrente(string titular, int numeroConta)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaCorrente(string titular, int numeroConta, double saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            valor += 5.0;
            Saldo -= valor;
        }

        public override string ToString()
        {
            return "Conta Corrente: " + NumeroConta.ToString() + "\n" +
            "Titular: " + Titular + "\n" +
            "Saldo: " + Saldo.ToString("F2") + "\n";
        }
    }
}
