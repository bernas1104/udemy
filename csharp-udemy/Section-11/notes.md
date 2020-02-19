Exceções

No .NET, é um objeto herdado da classe System.Exception.

Quando lançada, é propagada na stack até que seja tratada ou o programa encerrado.

.NET possui uma variedade de exceções disponibilizadas pelas bibliotecas padrões, e possui uma ApplicationException
para que o programador crie novas exceções próprias do seu programa.

Qual a motivação? Tratar erros de maneira consistente e flexível, usando boas práticas.

Vantagens:
	- Delega a lógica do erro para classe/método responsável;
	- Trata de forma organizada (inclusive hierárquica);
	- Pode carregar dados quaisquer;

--------------------------------------------------------------------------------

Try-Catch

Bloco Try: Contém o código que representa a execução normal que *pode* acarretar uma exceção.
Bloco Catch: Contém o código a ser executado caso ocorra uma exceção. A exceção deve ser especificada!

try {
	//
} catch (ExceptionType e) {
	//
} catch (ExceptionType e) {
	//
} 
...

Pode-se colocar a classe mais genérica (Exception), porém é recomendável utilizar a mais específica possível.

Bloco Finally: Executa independentemente da exceção ocorrer! Utilização clássica é: fechar arquivos/conexão com BD.