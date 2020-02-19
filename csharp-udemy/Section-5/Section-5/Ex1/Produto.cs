using System;
namespace Ex1
{
    public class Produto
    {
        /*
         * Ordem sugerida de implementação das classes em C#:
         * - Atributos privados;
         * - Propriedades autoimplementadas;
         * - Construtores;
         * - Propriedades customizadas;
         * - Outros métodos da classe.
         */

        string _nome;
        /*
         * Uma forma de melhorar os SET/GET é utilizando as Properties.
         * São uma mistura de atributos com métodos, utilizando o melhor
         * dos dois mundos.
         * O "value" é o "argumento" do método SET passado para fazer a
         * operação.        
         */

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /*
         * As Properties ainda podem ser melhoradas de novo. Para isso,
         * usa-se as AUTO Properties. Quando precisamos de métodos get/set
         * que não necessecitem de nenhuma lógica adicional, podemos usar
         * as Auto Properties.
         */

        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return (double)Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}