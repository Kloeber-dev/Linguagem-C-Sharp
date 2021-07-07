using System;

namespace Programa12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando switch, escreva um programa que leia um inteiro entre 1 e 7 e imprima o dia da semana correspondente a este número. Isto é, domingo se 1, segunda-feira se 2, e assim por diante.

            Console.WriteLine("Digite um número de 1 a 7: ");
            byte num = byte.Parse(Console.ReadLine());
            
            switch (num)
            {
                case 1: 
                    Console.WriteLine("Domingo"); 
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira"); 
                    break;
                case 3: 
                    Console.WriteLine("Terça-Feira"); 
                    break;
                case 4: 
                    Console.WriteLine("Quarta-Feira"); 
                    break;
                case 5: 
                    Console.WriteLine("Quinta-Feira"); 
                    break; 
                case 6: 
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7: 
                    Console.WriteLine("Sábado"); 
                    break;
                default:
                Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
    }
}
