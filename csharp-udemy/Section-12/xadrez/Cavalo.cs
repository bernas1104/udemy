using System;
using System.Collections.Generic;
using System.Text;
using Section_12.tabuleiro;

namespace Section_12.xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "C";
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao ver = new Posicao(pos.linha, pos.coluna);

            ver.definirPosicao(pos.linha - 1, pos.coluna - 2);
            if(tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha - 2, pos.coluna - 1);
            if(tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha - 2, pos.coluna + 1);
            if(tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha - 1, pos.coluna + 2);
            if(tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            //

            ver.definirPosicao(pos.linha + 1, pos.coluna - 2);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha + 2, pos.coluna - 1);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha + 2, pos.coluna + 1);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            ver.definirPosicao(pos.linha + 1, pos.coluna + 2);
            if (tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
            }

            return mat;
        }
    }
}
