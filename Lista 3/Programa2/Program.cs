using System;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que escreva na tela, de 1 ate 100, de 1 em 1, 3 vezes. A primeira vez você deve usar a estrutura de repetição for, a segunda while, e a terceira do -while.

            Console.WriteLine("Estrutura com laço 'for'");
            for (int i = 0; i < 100; ++i)
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine("\nEstrutura com laço 'while'");
            int c = 0;
            while (c < 100){
                Console.WriteLine(c+1);
                ++c;
            }

            Console.WriteLine("\nEstrutura com laço 'do -while'");
            int cont = 0;
            do
            {
                Console.WriteLine(cont+1);
                ++cont;
            } while (cont < 100);
        }
    }
}
