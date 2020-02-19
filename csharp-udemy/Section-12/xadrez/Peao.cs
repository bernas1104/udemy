using System;
using System.Collections.Generic;
using System.Text;
using Section_12.tabuleiro;

namespace Section_12.xadrez
{
    class Peao : Peca
    {
        private PartidaDeXadrez partida;

        public Peao(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao ver = new Posicao(pos.linha, pos.coluna);
            
            if(cor == Cor.Branca)
            {
                ver.definirPosicao(pos.linha - 1, pos.coluna);
                if(tab.posicaoValida(ver) && livre(ver))
                {
                    mat[ver.linha, ver.coluna] = true;
                }
                
                ver.definirPosicao(pos.linha - 2, pos.coluna);
                if(tab.posicaoValida(ver) && livre(ver) && qteMovimentos == 0)
                {
                    mat[ver.linha, ver.coluna] = true;
                }

                ver.definirPosicao(pos.linha - 1, pos.coluna - 1);
                if(tab.posicaoValida(ver) && existeInimigo(ver))
                {
                    mat[ver.linha, ver.coluna] = true;
                }

                ver.definirPosicao(pos.linha - 1, pos.coluna + 1);
                if(tab.posicaoValida(ver) && existeInimigo(ver))
                {
                    mat[ver.linha, ver.coluna] = true;
                }

                // #jogadaEspecial En Passant
                if(pos.linha == 3)
                {
                    Posicao esquerda = new Posicao(pos.linha, pos.coluna - 1);
                    if(tab.posicaoValida(esquerda) && existeInimigo(esquerda) && tab.peca(esquerda) == partida.vulneravelEnPassant)
                    {
                        mat[esquerda.linha - 1, esquerda.coluna] = true;
                    }

                    Posicao direita = new Posicao(pos.linha, pos.coluna + 1);
                    if(tab.posicaoValida(direita) && existeInimigo(direita) && tab.peca(esquerda) == partida.vulneravelEnPassant)
                    {
                        mat[direita.linha - 1, direita.coluna] = true;
                    }
                }
            }
            else
            {
                ver.definirPosicao(pos.linha + 1, pos.coluna);
                if (tab.posicaoValida(ver) && livre(ver))
                {
                    mat[ver.linha, ver.coluna] = true;
                }

                ver.definirPosicao(pos.linha + 2, pos.coluna);
                if (tab.posicaoValida(ver) && livre(ver) && qteMovimentos == 0)
                {
                    mat[ver.linha, ver.coluna] = true;
                }

                ver.definirPosicao(pos.linha + 1, pos.coluna - 1);
                if (tab.posicaoValida(ver) && existeInimigo(ver))
                {
                    mat[ver.linha, ver.coluna] = true;
                }

                ver.definirPosicao(pos.linha + 1, pos.coluna + 1);
                if (tab.posicaoValida(ver) && existeInimigo(ver))
                {
                    mat[ver.linha, ver.coluna] = true;
                }

                // #jogadaEspecial En Passant
                if (pos.linha == 4)
                {
                    Posicao esquerda = new Posicao(pos.linha, pos.coluna - 1);
                    if (tab.posicaoValida(esquerda) && existeInimigo(esquerda) && tab.peca(esquerda) == partida.vulneravelEnPassant)
                    {
                        mat[esquerda.linha + 1, esquerda.coluna] = true;
                    }

                    Posicao direita = new Posicao(pos.linha, pos.coluna + 1);
                    if (tab.posicaoValida(direita) && existeInimigo(direita) && tab.peca(esquerda) == partida.vulneravelEnPassant)
                    {
                        mat[direita.linha + 1, direita.coluna] = true;
                    }
                }
            }

            return mat;
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
