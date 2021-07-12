using System;

namespace Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia um número inteiro positivo par N e imprima todos os números pares de 0 até N em ordem crescente.

            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if ((num > 0) && (num % 2 == 0))
            {
                for (int i = 0; i <= num; ++i)
                    if (i % 2 == 0)
                        Console.Write(i + " ");
            }
        }
    }
}
