using System;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que peça ao usuário para digitar 10 valores e some-os.
            int[] valores = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine("Digite o " + (i+1) +"º valor: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            int soma = 0;
            foreach(int i in valores)
            {
                soma += valores[i];
            }

            Console.WriteLine("A soma dos números é: " + soma);
        }
    }
}
