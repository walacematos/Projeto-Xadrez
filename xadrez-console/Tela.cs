using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimitTabuleiro(Tabuleiro Tab)
        {
            for (int i=0; i<Tab.Linhas; i++)
            {
                for (int j=0; j<Tab.Colunas; j++)
                {
                    if (Tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(Tab.peca(i, j) + " ");
                    }   
                }
                Console.WriteLine();
            }
        }
    }
}
