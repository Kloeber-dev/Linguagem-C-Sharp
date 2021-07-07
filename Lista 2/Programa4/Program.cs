using System;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que, dados dois números inteiros, mostre na tela o maior deles, assim como a diferença existente entre ambos.

            Console.WriteLine("Digite o 1º número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O número " + num1 + " é maior do que " + num2);
                Console.WriteLine("A diferença entre ambos é: " + (num1 - num2));
            }
            else if(num2 > num1)
            {
                Console.WriteLine("O número " + num2 + " é maior do que " + num1);
                Console.WriteLine("A diferença entre ambos é: " + (num2 - num1));
            }
            else
            {
                Console.WriteLine("Os números " + num1 + " e " + num2 + " são iguais!");
                Console.WriteLine("A diferença entre ambos é de " + (num1 - num2));
            }
        }
    }
}
