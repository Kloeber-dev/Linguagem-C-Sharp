using System;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que determine o mostre os cinco primeiros múltiplos de 3, considerando números maiores que 0.
            for (int i = 1; i <= 5; ++i)
            {
                int resultado = i * 3;
                Console.WriteLine("3 X " + i + " = " + resultado);
            }
        }
    }
}
