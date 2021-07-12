using System;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia um número inteiro N e depois imprima os N primeiros números naturais ímpares.

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
                Console.WriteLine("O parâmetro não condiz um limite de números naturais");

            for (int i = 0; i <= num; ++i)
            {
                if(i % 3 == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
