using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    class Tela
    {
        public static void ImprimitTabuleiro(Tabuleiro Tab)
        {
            for (int i = 0; i < Tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    imprimirPeca(Tab.peca(i, j));

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimitTabuleiro(Tabuleiro Tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOrigial = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < Tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (posicoesPossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOrigial;
                    }
                    imprimirPeca(Tab.peca(i, j));

                }
                Console.WriteLine();
                Console.BackgroundColor = fundoOrigial;
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOrigial;
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");

            }
        }
    }
}
