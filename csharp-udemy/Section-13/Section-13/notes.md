File, FileInfo e IOException

A classe File difere da FileInfo pela simplecidade, oferencendo métodos estáticos
para manipulação de arquivos. A File irá realizar uma verficação de segurança
antes de qualquer operação, gerando um overhead maior.

No caso do FileInfo, não há verificação de segurança antes de toda operação
(apenas na hora que é instânciado ?) e, portanto, há uma maior velocidade na
execuçao do código.

O IOException é a classe que representa todas as exceções que podem ocorrer quando
usando arquivos.

--------------------------------------------------------------------------------

FileStream disponibiliza uma stream associada ao arquivo, permitindo leitura e
escrita com suporte a arquivos binários.

StreamReader é uma stream capaz de ler caracteres a partir de uma stream binária
(ex: FileStream). Possui suporte a dados no formato texto.

            --- StreamReader --- FileStream --- ARQUIVO
            
FileStream e StreamReader são recursos que não são gerenciados pelo CLR, e sim
pelo OS. Dessa forma, necessitam ser explícitamente fechados antes do final do
programa (.Close()).
            
--------------------------------------------------------------------------------

Bloco 'using'

É uma forma simplificada de garantir que objetos 'IDisposable' (Streams, Font,
etc) serão fechados.

--------------------------------------------------------------------------------

StreamWriter

É uma stream capaz de escrever caracteres a partir de uma stream binária (ex:
FileStream).

            --- StreamWriter --- FileStream --- ARQUIVO
            
--------------------------------------------------------------------------------

Directory, DirectoryInfo

Lógica semelhante ao File/FileInfo, porém para classes que disponiblizam operações
sobre diretórios.

--------------------------------------------------------------------------------

Path

Realiza operações com strings que contém informações de arquivos ou pastas.