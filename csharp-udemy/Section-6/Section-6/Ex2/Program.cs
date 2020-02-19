using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];

            for(int i = 0; i < 9; i++)
            {
                Quarto q = new Quarto(false);
                quartos[i] = q;
            }

            int n;
            Console.Write("Quantos estudantes irão alugar quartos? ");
            n = int.Parse(Console.ReadLine());
            while(n <= 0 || n >= 10)
            {
                Console.WriteLine("No mínimo 1 e no máximo 10 estudantes.");
                Console.Write("Quantos estudantes irão alugar quartos? ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informações do aluguel do " + (i+1) + "-ésimo estudante:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                while((quartos[quarto].Ocupado == true))
                {
                    Console.WriteLine("Quarto não pode ser escolhido. Escolha outro.");
                    Console.Write("Quarto: ");
                    quarto = int.Parse(Console.ReadLine());
                }

                Estudante ocupante = new Estudante(nome, email);
                quartos[quarto].Ocupado = true;
                quartos[quarto].Ocupante = ocupante;

                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(quartos[i]);
            }
        }
    }
}
