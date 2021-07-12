using System;

namespace Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um programa que faça leitura de vários números inteiros, até que se digite um número negativo. O programa tem que retornar o maior e o menor número lido.
            int num = 0; int maior = 0; int menor = 0;

            Console.WriteLine("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                maior = num;
                menor = num;
            }

            do
            {
                Console.WriteLine("Digite um número inteiro: ");
                num = int.Parse(Console.ReadLine());
                if(num > 0)
                {
                    if (num > maior)
                        maior = num;

                    if (num < menor)
                        menor = num;
                }
                
            } while(!(num < 0));

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
        }
    }
}
