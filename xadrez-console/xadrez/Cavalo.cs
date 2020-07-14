using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "C";
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
            {
                pos.definirValores(posicao.Linha - 1, posicao.Coluna - 2);
                if (tabuleiro.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.Linha - 2, posicao.Coluna - 1);
                if (tabuleiro.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.Linha - 2, posicao.Coluna + 1);
                if (tabuleiro.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.Linha - 1, posicao.Coluna + 2);
                if (tabuleiro.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.Linha + 1, posicao.Coluna + 2);
                if (tabuleiro.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.Linha + 2, posicao.Coluna + 1);
                if (tabuleiro.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.Linha + 2, posicao.Coluna - 1);
                if (tabuleiro.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.Linha + 1, posicao.Coluna - 2);
                if (tabuleiro.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                return mat;
            }
        }
    }
}
