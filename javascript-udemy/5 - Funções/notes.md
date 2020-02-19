First-Class Object

    JavaScript é uma linguagem multiparadigma, o que significa que pode ser programada
    de forma imperativa, orientada a objetos ou funcional.

    As funções são as principais componentes da linguagem. Podem ser armazenadas
    em variáveis, podem ser retornos de funções, etc...

    Ainda, uma funções pode conter outras funções!

Parâmetro Padrão
    Pode-se definir, na declaração dos parâmetros de uma função, os valores 'default'
    dos parâmetros. Isso serve para quando um parâmetro não é informado e, assim, um
    valor determinado é passado em seu lugar.

"this" pode variar
    Em funções 'normais' (i.e. function(var...) {}) o 'this' pode variar de acordo com
    o contexto que realizou a chamada da função. Já no caso se funções arrow, não há
    variação do 'this', que é definido considerando o contexto no qual a função arrow
    foi criada.

"this" e função bind()
    Serve para definir - amarrar - a referência a ser 'observada' pela palavra-chave
    'this'.

        pessoa = {
            saudacao: 'bom dia!',
            falar() { console.log(this.saudacao) }
        }

        const falarDePessoa = pessoa.falar.bind(pessoa)
        falarDePessoa()

        > bom dia!