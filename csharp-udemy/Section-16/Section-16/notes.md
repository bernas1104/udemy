Comparison<T>

Suponha uma classe Product com seus atributos (quaisquer). Queremos criar uma forma
de ordanar uma lista de Products e, dessa maneira, podemos utilizar a interface
IComparable<Product>.

No entanto, a classe não fica fechada para alteração: caso seja necessário alterar
o critério de ordenação, será necessário abrir a classe e alterar o código.

Para evitar isso, podemos criar uma nova sobrecarga do método "Sort" da classe
List: public void Sort(Comparison<T> comparison)

Dessa forma, podemos criar uma função auxiliar estática que irá realizar a comparação
entre dois Products - utilizando, por exemplo, seus nomes - e irá retornar um inteiro.

    static int CompareProducts(Product p1, Product p2) {
        return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    }
    
Com isso, ao utilizar a função Sort, podemos passar a referência para essa função
list.Sort(CompareProducts), e teremos uma lista ordenada. O nome desse mecânismo
é 'Delegate'.

A linguagem C# também possui suporte a programação funcional - cálculo Lambda.
Assim, ao invés de criar uma função que só será utilizada uma única vez, pode-se
utilizar uma função lambda para realizar um Delegate.

    list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
    
--------------------------------------------------------------------------------

Programação Funcional e Cálculo Lambda

Comparação entre Funcional e Imperativo por meio de tabela nos slides fornecidos.
Olhar com calma quando for possível e analisar os exemplos.

--------------------------------------------------------------------------------

Delegates

É uma referência (com type safety) para um ou mais métodos. Comunmente usado para
comunicação entre objetos de forma flexível e extensível; E parametrização de
operações por métodos (programação funcional).

Pré-definidos: Action, Func e Predicate.

Por ser type safety, o delegate deve casar com a assinatura dos métodos que vierem
a ser delegados.

--------------------------------------------------------------------------------

Multicast Delegate

São delegates que guardam referência para mais de um método. Para adicionar uma
referência, utiliza-se '+='. A chamada "Invoke" executa todos os métodos na ordem
que foram adicionados. Faz mais sentido para métodos void.

--------------------------------------------------------------------------------

Predicate

É um tipo de delegate que recebe um objeto <T> e retorna um booleano.

    public delegate bool Predicate<in T>(T obj);
    
Um exemplo de Predicate é visto na função list.RemoveAll. A função recebe um
Predicate e remove todos os itens da lista que testarem "true" para uma dada
condição.

    list.RemoveAll(p => p.Price >= 100.00); // Remove todos os objetos que tenham
    preço maior ou igual a 100.00.
    
--------------------------------------------------------------------------------

Action

É um tipo de delegate que recebe zero ou mais objetos e retorna void.

    public delegate void Action();
    public delegate void Action<in T1, in T2, ...> Action(T1 arg1, T2 arg2, ...)

Um exemplo de utilização é na função de listas ForEach().    

--------------------------------------------------------------------------------

Func

É um tipo de delegate que recebe zero ou mais objetos e retorna um valor

    public delegate TResult Func<out TResult>();
    public delegate TResult Func<in T1, in T2, ..., out TResult>(T1 arg1, T2 arg2, ...);
    
Um exemplo de Func é a função de lista Select. A função recebe um Func com um objeto
da lista e retorna um valor especificado. No exemplo abaixo, a lista de produtos
é iterada, retornando os nomes de todos os produtos (strings) na forma de um
IEnumerable, que é, posteriormente, convertido para o tipo List.

    List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
    
--------------------------------------------------------------------------------

LINQ

Para trabalhar com LINQs são necessários três passos:
    1. Criar um data source (coleção, array, recurso de E/S, etc);
    2. Definir a query;
    3. Executar a query (foreach ou alguma operação terminal);
    
No exemplo, usa-se uma coleção (array de inteiros) e aplica-se o método Where
que recebe uma Func/Predicate, retornando os números que são pares e, após, multiplica
estes números por 10.

É uma forma de tornar o código mais fácil de se entender e menos verboso, utilizando
para isso, o poder da programação funcional.

LINQ se assemelha com consultas SQL. Um fato curioso sobre a sua utilização é que
na execução de determinadas queries, pode ser necessário selecionar um objeto que
não existe. Quando isso ocorre, podemos criar um objeto de forma semelhante a uma
expressão lambda.

    ...Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name})
    // O 3o argumento do objeto dinâmico é um alias, que também é semelhante a
    a estrutura de alias do SQL.

--------------------------------------------------------------------------------

LINQ Referência

A coleção LINQ possui uma seŕie de métodos para as mais diversas situações, como
por exemplo: Filtering; Sorting; Set; Quantification; Porjection; Partition; Join;
Grouping; Generational; Equality; Element; Conversions; Concatenation; Aggregation.

--------------------------------------------------------------------------------

LINQ Demo Parte I e II --> Repositório Git com uma série de exemplos.

--------------------------------------------------------------------------------

Nivelamento: Álgebra Relacional e SQL

Operações definidas dentro do modelo relacional: restrição, projeção, produto
cartesiano e junção (produto cartesiano + restrição).

Caso necessário, olhar os exemplos no PDF.

Para ficar mais semelhante SQL, é possível criar queries da seguinte forma:

    var r1 = from p in products
                where p.Category.Name = "Tools"
                select p.Name;
                
Assim como nos LINQs, o intelisense da IDE funciona normalmente, facilitando o
desenvolvimento.