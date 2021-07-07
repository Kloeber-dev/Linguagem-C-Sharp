using System;

namespace Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia 2 notas de um aluno, verifique se as notas são válidas e exiba na tela a média destas notas. Uma nota válida deve ser, obrigatoriamente, um valor entre 0.0 e 10.0, onde caso a nota não possua um valor válido, este fato deve ser informado ao usuário e o programa termina.
            
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            
            if(nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("Você digitou uma nota inválida! ");
                return;
            }
            
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            
            if (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("Você digitou uma nota inválida! ");
                return;
            }
            
            Console.WriteLine("A média do aluno é: " + ((nota1 + nota2) / 2));
        }
    }
}
