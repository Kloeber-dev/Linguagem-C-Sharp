using System;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia dois números inteiros e mostre qual deles é maior.

            Console.WriteLine("Digite um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("O número " + num1 + " é o maior");
            else
                Console.WriteLine("O número " + num2 + " é o maior");
        }
    }
}
