pessoa = {
    saudacao: 'bom dia!',
    falar() { console.log(this.saudacao) }
}

const falarDePessoa = pessoa.falar.bind(pessoa)
falarDePessoa()