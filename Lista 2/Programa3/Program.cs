using System;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba um número inteiro e mostre se este número é par ou ímpar.
                        
            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("O número " + num + " é par!");
            else
                Console.WriteLine("O número " + num + " é ímpar!");
        }
    }
}
