using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Nullable é uma forma para que structs (tipos padrão ou
             * tipos definidos pelo usuário) possam assumir o valor null
             * ou serem opcionais.
             * Podem ser declaradas de duas formas:
             *            
             * - Nullable<double> var = null;
             * - double? var = null;
             * 
             * As variáveis Nullable têm os seguintes métodos:
             * 
             * - GetValueOrDefault: retorna o valor da variável ou o valor
             * padrão. Se a variável for null, retorna seu valor padrão. Caso
             * contrário, retorna o valor atribuído a esta;
             * - HasValue: a PROPRIEDADE retorna um booleano que diz se a variável
             * contém um valor ou é nula.           
             * - Value (lança uma exceção se não houver valor): a PROPRIEDADE retorna
             * o valor da variável. Caso esta seja nula, é lançada uma exceção.           
             * 
             * Um Nullable não pode ser atribuído para um struct comum.
             * 
             * Operador de nulo condicional (??): quando utilizado, determina que
             * a variável deve obter um valor x ou y, a depender da possível nulidade
             * do valor x. Por exemplo:
             * 
             * double? x = null;
             * double y = x ?? 0.0 // Nesse caso, y = 0.0 pois x é nulo.           
             */

            double? x = null;
            double? y = 10.0;
            double z = x ?? 15.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x != null)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            Console.WriteLine(y.Value);
            Console.WriteLine(z);

            /*
             * Para alocação de um vetor de objetos, deve-se executar dois passos:
             * 
             * 1. Classe[] var = new Classe[x];
             * 2. var[i] = new Classe(...);
             * 
             * Dessa forma, cria-se uma instância do vetor de objetos e uma instância
             * do próprio objeto para ser alocada no vetor.
             */

            int n = int.Parse(Console.ReadLine());
            Produto[] p = new Produto[n];

            for(int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto prod = new Produto(nome, preco);
                p[i] = prod;
            }

            /*
             * Modificador de parâmetros - PARAMS
             * É uma forma de tornar a quantidade de parâmetros em um método variável.
             * Dessa forma, ao invés de declarar vários métodos com quantidade variável de argumentos
             * podemos simplesmente fazer: public ~static~ type Method(params type[] vars)
             * Assim, podemos passar quantos argumentos forem necessários e lê-los como se fosse
             * um vetor.
             * Ainda, não será passar os valores como vetores, tornando a escrita menos
             * verbosa.
             */

            int s1 = Calculadora.Sum(1, 2, 6, 3, 2);
            int s2 = Calculadora.Sum(2, 4, 6);

            Console.WriteLine(s1);
            Console.WriteLine();
            Console.WriteLine(s2);

            /* REF e OUT
             * REF é uma forma de trabalhar com referência. Podemos passar a
             * referência de uma variável para um método e, ao realizar modificações
             * na variável passado, as mudanças são "retornadas" (sem uso do return)
             * para a função que chamou o método. É uma forma de simular o & de C.
             * 
             * public ~static~ type Method(ref type var, ...)
             * 
             * Method(ref var);
             * 
             * OUT é similar ao REF, mas não exige que a variável tenha sido iniciada.
             * Seria como se fosse uma variável de saída, como indica o nome "out".
             * 
             * Deve-se evitar o uso de ambos, considerados "code smells" (design ruim).           
             */

            Console.WriteLine();
            int a = 10;
            int b;
            Calculadora.Triple(ref a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            /* BOXING e UNBOXING
             * BOXING é a conversão de um tipo valor para um tipo referência.
             * 
             * int x = 20;
             * Object obj = x;
             * 
             * UNBOXING é o processo inverso.
             * 
             * int y = (int) obj;
             * 
             * Para o processo inverso, é necessário um casting e que o objeto
             * seja compatível com o tipo valor.
             */

            int c = 20;
            Object obj = c;
            int d = (int)obj;
            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine(obj);
            Console.WriteLine(d);

            // FOREACH é uma forma opcional e simplificada de percorrer coleções
            Console.WriteLine();
            string[] vect = new string[] { "Maria", "Alex", "Bob" };
            foreach (string e in vect)
            {
                Console.WriteLine(e);
            }

            /* Listas
             * "Vetor" que pode crescer e diminuir de acordo com a necessidade.
             * System.Collections.Generic
             * List<type> myList = new List<type>();
             * 
             * Vantagens:
             * - Tamanho variável;
             * - Fácil inserir e deletar;
             * 
             * Desvantagens:
             * - Acesso sequencial;
             * 
             * No uso do método ".Insert(int, type)", se houver um dado na posição
             * passada, o novo dado é inserido na mesma e os dados, a partir daquela
             * posição, são "empurrados" uma posição pra cima.
             */

            Console.WriteLine();
            List<string> myList = new List<string> { "Maria", "Alex", "Bob" };
            foreach(string f in myList)
            {
                Console.WriteLine(f);
            }

            /* Alguns dos métodos de Listas utilizam predicados como argumentos.
             * Um exemplo é o método FindAll. Para declarar um predicado, temos
             * o exemplo abaixo:
             */

            Console.WriteLine();
            List<string> myList2 = myList.FindAll(w => w.Length == 5);
            foreach(string g in myList2)
            {
                Console.WriteLine(g);
            }

            // Predicados serão abordados em maior profundidade na seção 16

            /* As matrizes em C# utilizam uma declaração um pouco diferente do
             * usual. Ao invés de usarmos multiplos [], usa-se apenas um com uma
             * virgula dentro para indicar a matriz.
             */

            double[,] mat = new double[2, 3];

            Console.WriteLine();
            Console.Write("Tamanho da matriz: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[m, m];

            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("Insira o " + j + "-ésimo elemento da " + i + "-ésima linha: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int neg = 0;

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (matriz[i, j] < 0)
                        neg++;
                }
            }
            Console.Write("Total de números negativos: " + neg);
            Console.WriteLine();
            Console.WriteLine("Diagonal da matriz:");
            for (int i = 0; i < m; i++)
            {
                Console.Write(matriz[i, i] + "  ");
            }

            Console.WriteLine();
            Console.WriteLine();

            /* Conjuntos - HashSet
             * Coleção de objetos semelhante ao conceito de conjunto matemático.
             * Não há repetição de elementos, não há uma 'posição' dentro do conjunto,
             * oferece operações eficientes de conjunto.
             * 
             * Usa o mesmo namespace de Listas.
             * 
             * HashSet<type> var = new HashSet<type>();
             */

            HashSet<int> A = new HashSet<int> { 3, 5, 8, 9 };
            HashSet<int> B = new HashSet<int> { 3, 4, 5 };

            foreach(int X in A)
            {
                Console.WriteLine(X);
            }

            Console.WriteLine();

            foreach (int X in B)
            {
                Console.WriteLine(X);
            }
        }
    }
}
