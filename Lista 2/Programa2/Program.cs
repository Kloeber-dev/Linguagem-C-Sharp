using System;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia um número, e caso ele seja positivo faça: 
            //• O número digitado ao quadrado;
            //• A raiz quadrada do número digitado.

            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("O quadrado deste número é: " + Math.Pow(num, 2));
                Console.WriteLine("A raiz quadrada deste número é: " + Math.Sqrt(num));
            }
        }
    }
}
