Interface

Tipo que define um conjunto de operações que uma classe (ou struct) deve implementar.
Estabelece um "contrato" que a classe deve cumprir.

Seu proposito é gerar sistemas de baixo acoplamento e flexíveis.

No exemplo do curso, há uma classe RentalService que depende fortemente da classe
BrazilTaxService. Sem a utilização de Interfaces, caso haja uma alteração sobre
qual serviço de impostos utilizar (por exemplo, trocar BrazilTaxServices por
ArgentinaTaxServices), o programador deverá mexer com 2 classes: criar a classe
ArgentinaTaxServices e modificar a  classe RentalService para utilizá-la, o que
não é desejável.

A forma ideal de implementação é com a utilização de uma Interface genérica.
Criando uma Interface TaxService, podemos deixar o serviço genérico para que
qualquer outra classe possa implementá-lo posteriormente, sem precisar alterar a
estrutura da classe RentalService.

Utiliza-se o "I" maiúsculo para identificar Interfaces em C# (convenção).

--------------------------------------------------------------------------------

Inversão de controle e injeção de dependência

Quando não utilizamos Interfaces, temos os seguintes problemas:
    - Acoplamento forte;
    - A classe conhece a dependência concreta;
    - Se a classe concreta muda, é preciso mudar a classe;
    
Com a utilização de Interfaces, amenizamos essas questões:
    - Acoplamento fraco;
    - A classe não conhece a dependência concreta;
    - Se a classe concreta mudar, a classe não muda;
    
A injeção de dependência, então, é a inserção da classe concreta - implementada
via Interface - no construtor da classe (pode ser implementada de outras maneiras).

A inversão de controle é um padrão de desenvolvimento, que retira da classe  a 
responsabilidade de instanciar suas dependências.

--------------------------------------------------------------------------------

Herdar vs. Cumprir Contrato

Aspectos comuns:
    - Relação "é-um";
    - Generalização/Especialização;
    - Polimorfismo;
    
Heranças => Reuso!
Interface => Contrato a ser cumprido! (não há reuso)

Para combinar ambos, pode-se criar uma Interface, uma classe abstrata que implementa
a Interface e, por fim, classe(s) que herdem da classe abstrata. Dessa forma,
tem-se o reuso de heranças e o contrato definido.

--------------------------------------------------------------------------------

Herança Múltipla e o problema do diamante

Herança múltipla (problema do diamante especificamente) pode gerar uma ambiguidade
devido ao um mesmo método em mais de uma superclasse. Maioria das linguagens
não permite herança múltipla, deivido a esse problema.

Para resolver esse problema, pode-se utilizar Interfaces. Assim, uma classe que
teria múltiplas heranças acessa múltiplas interfaces e implementa os métodos da
forma que for necessária, sem gerar ambiguidades, pois não há reuso.

--------------------------------------------------------------------------------

Interface IComparable

Interface que deve ser utilizada para comparar objetos (i.e. verificar dois objetos
são ==, > ou < ... 0, 1, -1).