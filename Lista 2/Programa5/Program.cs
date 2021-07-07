using System;

namespace Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba dois números e mostre o maior. Se por acaso, os dois números forem iguais, imprima a mensagem números iguais.

            Console.WriteLine("Digite um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine(num1 + " é maior que " + num2);
            else if (num2 > num1)
                Console.WriteLine(num2 + " é maior que " + num1);
            else
                Console.WriteLine("Números Iguais!");
        }
    }
}
