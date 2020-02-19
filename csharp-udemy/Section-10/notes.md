Herança

Tipo de associação que permite que uma classe herde dados e comportamentos

Vantagens:
	- Reuso;
	- Polimorfismo;

Sintaxe:
	: (estende)
	base (ref. para super classe)

Relação "é-um" onde a superclasse (base) é a generalização e a subclasse (derivada) é uma especialização. Diferente da composição, é uma associação entre classes (e não entre objetos).

Protected é uma formar de permitir o acesso dos atributos da classe as subclasses e privar o acesso dos demais.

-------------------------------------------------------------------

Upcasting e Downcasting

Up~: é o casting da subclasse para superclasse;
	- Uso comum para polimorfismo;

Down~: é o casting da superclasse para subclasse;
	- Palavra as/is;
	- Uso comum é para métodos que recember parâmetros genéricos;

A palavra "is" serve para verificar se uma classe é do tipo da outra. No exemplo apresentado
na lição, uma BusinessAccount *NÃO* é do tipo de uma SavingsAccount e, portanto, ao fazer um
condicional "if(acc3 is BusinessAccount)" temos um retorno "false". O "is" é uma palavra de
tipo reflexiva, pois é capaz de determinar o tipo do objeto em tempo de execução.

------------------------------------------------------------------

Sobreposição/Sobrescrita - Virtual, override e base

O método comum que pode ser sobrescrito deve conter a palavra chave "virtual", enquanto que o
método que irá sobrescrevê-lo deve conter a palavra "override"

Ao utilizar a palavra base.<NomeMetodo>, podemos aproveitar o código da função original e adicionar
novos comportamentos.

------------------------------------------------------------------

Classes e métodos selados

Uma classe selada é uma que não pode possuir heranças. Já um método selado é um sobreposto que não
pode ser sobrescrito novamente. Para determinar esse comportamento, basta utilizar a palavra chave
"sealed".

Selar uma classe/método pode ser útil para evitar inconsistências e melhora a performance em tempo
de execução (atributos são analisados de forma mais rápida).

------------------------------------------------------------------

Introdução ao Polimorfismo

"Em OOP, polimorfismo é um recurso que permite que variáveis de um mesmo tipo mais genérico possam apontar para objetos de tipos específicos diferentes, tendo assim comportamentos diferentes conforme cada tipo específico.

A associação de tipo genérico em tipo específico é realizada em tempo de execução.
O compilador não sabe qual objeto está sendo chamado, apenas de qual classe genérica é o método.

------------------------------------------------------------------

Classes Abstratas

Classes que não podem ser instanciadas; É uma forma de garantir herança total.
Classes abstratas servem para reuso e polimorfismo. Permite também maior flexibilidade no código,
como por exemplo, listas de tipos específicos (que herdam da classe abstrata).

------------------------------------------------------------------

Métodos Abstratos

Métodos que não possuem implementação - usados quando a classe é muito genérica. Cada subclasse
deverá implementar os métodos de acordo com a necessidade. (Interfaces!)

Caso a classe possua pelo menos um método abstrato, ela será, também, abstrata.
