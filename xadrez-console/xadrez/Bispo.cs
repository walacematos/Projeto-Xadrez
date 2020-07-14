﻿
using tabuleiro;

namespace xadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "B";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //NO
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //NE
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //SE
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            //SO
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;
        }
    }
}
