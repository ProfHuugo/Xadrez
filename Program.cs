using System;
using tabuleiro;
using XADREZ;

namespace xadrez
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadKey();
        }
    }
}