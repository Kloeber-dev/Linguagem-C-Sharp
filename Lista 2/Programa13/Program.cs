using System;

namespace Programa13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que calcule e mostre a área de um trapézio. Sabe-se que: A = ((basemenor+basemenor)*altura)/2. Lembre-se a base maior e a base menor devem ser números maiores que zero.

            Console.WriteLine("====== CALCULE A ÁREA DO TRAPÉZIO ======");
            
            Console.WriteLine("Digite a base maior do trapézio: ");
            double bmaior = double.Parse(Console.ReadLine());
            
            if (bmaior <= 0)
            {
                while (bmaior <= 0)
                {
                    Console.WriteLine("REDIGITE A BASE MAIOR DO TRAPÉZIO: ");
                    bmaior = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite a base menor do trapézio");
            double bmenor = double.Parse(Console.ReadLine());
            
            if (bmenor <= 0)
            {
                while (bmenor <= 0)
                {
                    Console.WriteLine("REDIGITE A BASE MENOR DO TRAPÉZIO: ");
                    bmenor = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite a altura do trapézio: ");
            double altura = double.Parse(Console.ReadLine());
            
            if (altura <= 0)
            {
                while (altura <= 0)
                {
                    Console.WriteLine("REDIGITE A ALTURA DO TRAPÉZIO: ");
                    altura = double.Parse(Console.ReadLine());
                }
            }

            double area = ((bmaior + bmenor) * altura) / 2.0;

            Console.WriteLine("A área do Trapézio é: " + area);
        }
    }
}
