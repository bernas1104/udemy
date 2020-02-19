Código JavaScript é organizado por sentenças e blocos.

Os comentários em JavaScript são iguais na linguagem C, ou seja,
para 'implementar' comentários, utiliza-se // para comentários em
um única linha e /**/ para comentários em múltiplas linhas.

var, let e const
    - 'var' seguido de um nome identifica uma variável armazenada na
    memória; A atribuição é feita como em qualquer linguagem;
    - 'let' seguido de um nome é uma segunda forma de criar uma variável
    e armazena-la na memória; Difere do 'var' (ainda não explicado); A
    atribuição é igual a qualquer linguagem;
        - Uma primeira questão sobre var x let: dentro de um mesmo escopo
        é possível declarar 'var's como o mesmo nome, e, até, atribuir tipos
        de dados diferentes nas declarações; Já o 'let' não pode ser declarado
        várias vezes, mas pode receber dados diferentes; O fato de receber
        dados de tipos diferentes, deve-se ao fato da linguagem ter tipagem
        fraca (?);

    - 'const' declara constantes na linguagem JavaScript. Como o nome indica
    uma constante não pode ter seu valor alterado;

Tipagem Fraca
    - Implica que as variáveis podem assumir diversos tipos ao longo da
    execução (dinâmico), mas não quer dizer que as variáveis não possuam
    tipos específicos. A função 'typeof' pode indentificar o tipo da variável
    em um dado momento.

Tipo 'Number'
    - Caso o número seja algo como '1.0', o JS irá identificá-lo como um
    inteiro. No entando, se tivermos algo como '1.1', será consierado como
    um número de ponto flutuante;
    - A função '.toFixed(value)' determina a quantidade de casas decimais;
    - Alguns cuidados:
        - console.log(7 / 0) --> Resulta em 'Infinity';
        - console.log("10" / 2) --> Resulta em 5, pois o interpretador irá
        tentar converter a string em um número para realizar a operação;
        - console.log("Show!" * 2) --> NaN (Not a Number);
        - console.log(0.1 + 0.7) --> 0.79999... Deve-se ao fato da especificação
        da IEEE para que as operações de ponto flutuante sejam mais rápidas. É
        necessário tomar cuidado com a imprecisão das operações desse tipo;
        - console.log(10.toString()) --> Erro!
        - console.log((10.345).toFixed(2)) --> Funciona!

Math
    - É um objeto que possui uma série de constantes e funções matemáticas para
    uso nos programas escritos em JavaScript;

JavaScript não é uma linguagem que exibe muitos erros - apenas quando necessário.
No caso de, por exemplo, tentar acessar uma posição inexistente em um array,
o interpretador não retorna erros, apenas retorna nada. Isso (não retornar muitos
erros) possui vantagens e desvantagens que serão abordadas no futuro.

Template String
    - Utiliza-se da crase `` para gerar uma string onde tudo dentro das crases
    será considerado como texto. Facilita a concatenação de várias strings pois
    podemos utilizar ${} para declarar variáveis/expressões que irão fazer parte 
    da string sendo construída.

Hoisting
    É o efeito de se declara um 'var' em um bloco de código e este poder ser acessado
    fora dele. Ainda, 'anula' o efeito de linguagens imperativas. Por exemplo, o código
        
        console.log(a)
        var a = 2
        console.log(a)

    Irá printar o valor '2' em ambas as declarações 'console.log(a)', mesmo que na
    primeira, 'var a = 2' ainda não esteja declarada - na ordem do código.

Destructuring (ES2015)
    É uma forma mais prática de acessar elementos de um objeto. Ao invés de usar
    o operador de '.' ou '[]', utiliza-se a seguinte nomenclatura:

        const/var/let { a, b, c, ..., n } = objeto
        console.log(a, b, c, ..., n)

    Os nomes - a, b, c... - devem ser iguais aos nomes aos elementos do objeto.
    No entanto, há uma segunda forma para flexibilizar os nomes utilizados:

        const/var/let { a: b, c: d, ... } // atribuir o valor de 'a' à 'b' e 'c' à 'd'

    É possível, também, definir valores padroẽs, caso o elemento não seja definido
    no objeto:

        const/var/let { b = true } // receber o valor do elemento 'b' do objeto ou 'true'
        // caso não esteja definido

    Quando os dados são aninhados, deve-se garantir que o 'caminho' até eles existe.
    Caso contrário, será lançada uma exceção.
    O mecânismo de destructuring também é válido para arrays. Utiliza-se [] e pode-se
    ignorar elementos.