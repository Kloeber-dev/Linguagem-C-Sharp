using System;

namespace Programa14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados três valores, A, B, C, verificar se eles podem ser valores dos lados de um triângulo e, se forem, se e um triâangulo escaleno, equilátero ou isósceles, considerando os seguintes conceitos:
            //• O comprimento de cada lado de um triângulo é menor do que a soma dos outros dois lados;
            //• Chama - se equilátero o triângulo que tem três lados iguais;
            //• Denominam - se isóscele o triângulo que tem o comprimento de dois lados iguais; Recebe o nome de escaleno o triângulo que tem os três lados diferentes.

            Console.WriteLine("====== PROGRAMA DOS TRIÂNGULOS ======");

            Console.WriteLine("Digite o lado A");
            double a = double.Parse(Console.ReadLine());
            
            if (a <= 0)
            {
                while (a <= 0)
                {
                    Console.WriteLine("Redigite o lado A");
                    a = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite o lado B");
            double b = double.Parse(Console.ReadLine());
            
            if (b <= 0)
            {
                while (b <= 0)
                {
                    Console.WriteLine("Redigite o lado B");
                    b = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite o lado C");
            double c = double.Parse(Console.ReadLine());
            
            if (c <= 0)
            {
                while (c <= 0)
                {
                    Console.WriteLine("Redigite o lado C");
                    c = double.Parse(Console.ReadLine());
                }
            }

            if ((a < (b + c)) || (b < (a + c)) || (c < (a + b)))
            {
                if ((a == b) && (a == c))
                    Console.WriteLine("OS LADOS FORMAM UM TRIÂNGULO EQUILÁTERO");
                else if ((a == b) || (a == c) || (b == c))
                {
                    Console.WriteLine("OS LADOS FORMAM UM TRIÂNGULO ISÓSCELE");
                }
                else
                    Console.WriteLine("OS LADOS FORMAM UM TRIÂNGULO ESCALENO");
            }
            else
                Console.WriteLine("AS MEDIDAS NÃO FORMAM UM TRIÂNGULO!!");

        }
    }
}
