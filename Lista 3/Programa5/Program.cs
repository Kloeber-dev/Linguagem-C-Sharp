using System;

namespace Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que encontre o primeiro múltiplo de 11, 13 ou 17 após um número dado.
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if ((num % 11 == 0) || (num % 13 == 0) || (num % 17 == 0))
            {
                Console.WriteLine("O múltiplo mais próximo é: " + num);
            }
            else
            {
                int resto = num % 11;
                int resto2 = num % 13;
                int resto3 = num % 17;
                if(resto < resto2 && resto < resto3)
                {
                    Console.WriteLine("O múltiplo mais próximo está entre múltiplos de 11");
                    while(!(num % 11 == 0))
                    {
                        num += 1;
                    }
                    Console.WriteLine("O múltiplo mais próximo: " + num);
                }
                else if (resto2 < resto && resto2 < resto3)
                {
                    Console.WriteLine("O múltiplo mais próximo está entre múltiplos de 13");
                    while (!(num % 13 == 0))
                    {
                        num += 1;
                    }
                    Console.WriteLine("O múltiplo mais próximo: " + num);
                }
                else if (resto3 < resto && resto3 < resto2)
                {
                    Console.WriteLine("O múltiplo mais próximo está entre múltiplos de 17");
                    while (!(num % 17 == 0))
                    {
                        num += 1;
                    }
                    Console.WriteLine("O múltiplo mais próximo: " + num);
                }
            }
        }
    }
}
