using tabuleiro;

namespace xadrez
{

    class Peao : Peca
    {
        private PartidaDeXadrez partida;

        public Peao(Tabuleiro tab, Cor Cor, PartidaDeXadrez partida) : base(tab, Cor)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            return "P";
        }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos)
        {
            return tabuleiro.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            if (cor == Cor.Branca)
            {
                pos.definirValores(posicao.linha - 1, posicao.Coluna);
                if (tabuleiro.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.linha - 2, posicao.Coluna);
                Posicao p2 = new Posicao(posicao.linha - 1, posicao.Coluna);
                if (tabuleiro.posicaoValida(p2) && livre(p2) && tabuleiro.posicaoValida(pos) && livre(pos) && quantidadeDeMovimentos == 0)
                {
                    mat[pos.linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.linha - 1, posicao.Coluna - 1);
                if (tabuleiro.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.linha - 1, posicao.Coluna + 1);
                if (tabuleiro.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linha, pos.Coluna] = true;
                }

                //#JogadaEspecial en passant
                if (posicao.linha == 3)
                {
                    Posicao esquerda = new Posicao(posicao.linha, posicao.Coluna - 1);
                    if (tabuleiro.posicaoValida(esquerda) && existeInimigo(esquerda) && tabuleiro.peca(esquerda) == partida.vulneravelEnPassant)
                    {
                        mat[esquerda.linha -1, esquerda.Coluna] = true;
                    }
                    Posicao direita = new Posicao(posicao.linha, posicao.Coluna + 1);
                    if (tabuleiro.posicaoValida(direita) && existeInimigo(direita) && tabuleiro.peca(direita) == partida.vulneravelEnPassant)
                    {
                        mat[direita.linha - 1, direita.Coluna] = true;
                    }
                }


            }
            else
            {
                pos.definirValores(posicao.linha + 1, posicao.Coluna);
                if (tabuleiro.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.linha + 2, posicao.Coluna);
                Posicao p2 = new Posicao(posicao.linha + 1, posicao.Coluna);
                if (tabuleiro.posicaoValida(p2) && livre(p2) && tabuleiro.posicaoValida(pos) && livre(pos) && quantidadeDeMovimentos == 0)
                {
                    mat[pos.linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.linha + 1, posicao.Coluna - 1);
                if (tabuleiro.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linha, pos.Coluna] = true;
                }
                pos.definirValores(posicao.linha + 1, posicao.Coluna + 1);
                if (tabuleiro.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linha, pos.Coluna] = true;
                }
                if (posicao.linha == 4)
                {
                    Posicao esquerda = new Posicao(posicao.linha, posicao.Coluna - 1);
                    if (tabuleiro.posicaoValida(esquerda) && existeInimigo(esquerda) && tabuleiro.peca(esquerda) == partida.vulneravelEnPassant)
                    {
                        mat[esquerda.linha +1, esquerda.Coluna] = true;
                    }
                    Posicao direita = new Posicao(posicao.linha, posicao.Coluna + 1);
                    if (tabuleiro.posicaoValida(direita) && existeInimigo(direita) && tabuleiro.peca(direita) == partida.vulneravelEnPassant)
                    {
                        mat[direita.linha +1, direita.Coluna] = true;
                    }
                }
            }
                return mat;
            }
        }
    }