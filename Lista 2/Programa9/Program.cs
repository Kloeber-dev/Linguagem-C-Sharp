using System;

namespace Programa9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia um número inteiro maior do que zero e devolva, na tela, a soma de todos os seus algarismos. Por exemplo, ao numero 251 corresponder ao valor 8(2+5+1). Se o numero lido não for maior do que zero, o programa terminar a mensagem “Número inválido”.

            Console.WriteLine("Digite um número inteiro maior que 0: ");
            int num = int.Parse(Console.ReadLine());
            
            int soma = 0;

            if (num > 0)
            {
                for (int i = num; i > 0; i--)
                {
                    int resto = num % 10;
                    num = num / 10;
                    soma += resto;
                }
                Console.WriteLine("Soma dos algarismos: " + soma);
            }
            else
                Console.WriteLine("NÚMERO INVÁLIDO!");
        }
    }
}
