using System;
using System.Collections.Generic;
using System.Text;
using Section_12.tabuleiro;

namespace Section_12.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao ver = new Posicao(pos.linha, pos.coluna);
            
            ver.definirPosicao(pos.linha - 1, pos.coluna);
            while(tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
                if(tab.peca(ver) != null && tab.peca(ver).cor != this.cor)
                {
                    break;
                }
                ver.linha = --ver.linha;
            }

            ver.definirPosicao(pos.linha + 1, pos.coluna);
            while(tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
                if (tab.peca(ver) != null && tab.peca(ver).cor != this.cor)
                {
                    break;
                }
                ver.linha = ++ver.linha;
            }

            ver.definirPosicao(pos.linha, pos.coluna - 1);
            while(tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
                if(tab.peca(ver) != null && tab.peca(ver).cor != this.cor)
                {
                    break;
                }
                ver.coluna = --ver.coluna;
            }

            ver.definirPosicao(pos.linha, pos.coluna + 1);
            while(tab.posicaoValida(ver) && podeMover(ver))
            {
                mat[ver.linha, ver.coluna] = true;
                if(tab.peca(ver) != null && tab.peca(ver).cor != this.cor)
                {
                    break;
                }
                ver.coluna = ++ver.coluna;
            }

            return mat;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
