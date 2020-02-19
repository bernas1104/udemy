using System;
namespace Ex6
{
    public class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public Aluno()
        {
        }

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public void Aprovado()
        {
            if (NotaFinal() > 60.00)
                Console.WriteLine("APROVADO");
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60.00 - NotaFinal()).ToString("F2") + " PONTOS");
            }
        }
    }
}
