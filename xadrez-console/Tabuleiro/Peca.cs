namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeDeMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor )
        {
            posicao = null;
            this.cor = cor;
            tabuleiro = tab;
            quantidadeDeMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            quantidadeDeMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            quantidadeDeMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i=0; i<tabuleiro.Linhas; i++)
            {
                for (int j=0; j<tabuleiro.Colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }                    
                }
            }
            return false;
        }

        public bool movimentoPossiel(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }
        public abstract bool[,] movimentosPossiveis();
       
       
    }
}
