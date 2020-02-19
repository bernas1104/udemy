using System;
using System.Collections.Generic;
using System.Text;
using Section_12.tabuleiro;

namespace Section_12.xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez partida;

        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base (tab, cor)
        {
            this.partida = partida;
        }

        private bool testeTorreParaRoque(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p is Torre && p.cor == cor && p.qteMovimentos == 0;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao ver = new Posicao(0, 0);

            ver.definirPosicao(pos.linha - 1, pos.coluna - 1);
            if(tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha - 1, pos.coluna);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha - 1, pos.coluna + 1);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha, pos.coluna - 1);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha, pos.coluna + 1);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha + 1, pos.coluna - 1);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha + 1, pos.coluna);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha + 1, pos.coluna + 1);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            // #jogadaEspecial ROQUE
            if (qteMovimentos == 0 && !partida.xeque)
            {
                // Roque Pequeno
                Posicao posT1 = new Posicao(pos.linha, pos.coluna + 3);
                if (testeTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(pos.linha, pos.coluna + 1);
                    Posicao p2 = new Posicao(pos.linha, pos.coluna + 2);
                    if(tab.peca(p1) == null && tab.peca(p2) == null)
                    {
                        mat[pos.linha, pos.coluna + 2] = true;
                    }
                }

                // Roque Grande
                Posicao posT2 = new Posicao(pos.linha, pos.coluna - 4);
                if (testeTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(pos.linha, pos.coluna - 1);
                    Posicao p2 = new Posicao(pos.linha, pos.coluna - 2);
                    Posicao p3 = new Posicao(pos.linha, pos.coluna - 3);
                    if (tab.peca(p1) == null && tab.peca(p2) == null && tab.peca(p3) == null)
                    {
                        mat[pos.linha, pos.coluna - 2] = true;
                    }
                }
            }

            return mat;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
