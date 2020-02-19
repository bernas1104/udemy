using System;
namespace Ex3
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncreaseSalary(double percent)
        {
            Salario *= percent;
        }

        public override string ToString()
        {
            return ID + ", " + Nome + ", " + Salario.ToString("F2");
        }
    }
}
