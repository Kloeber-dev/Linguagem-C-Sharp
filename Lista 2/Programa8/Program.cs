using System;

namespace Programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba a altura e o sexo de uma pessoa e calcule e mostre seu peso ideal, utilizando as seguintes fórmulas (onde h corresponde a altura):
            //• Homens: (72, 7 * h) − 58
            //• Mulheres: (62, 1 * h) − 44,7

            Console.WriteLine("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o sexo \n \t 1-MASCULINO \t 2-FEMININO");
            byte sexo = byte.Parse(Console.ReadLine());

            switch (sexo)
            {
                case 1:
                    double pesoMasc = (72.7 * altura) - 58.0;
                    Console.WriteLine("Seu peso ideal é: " + Math.Round(pesoMasc, 1));
                    break;
                case 2:
                    double pesoFem = (62.1 * altura) - 44.7;
                    Console.WriteLine("Seu peso ideal é: " + Math.Round(pesoFem, 1));
                    break;
                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    break;
            }
        }
    }
}
