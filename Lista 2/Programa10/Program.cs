using System;

namespace Programa10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Façaa um algoritmo que calcule a média ponderada das notas de 3 provas. A primeira e a segunda prova tem peso 1 e a terceira tem peso 2. Ao final, mostrar a média do aluno e indicar se o aluno foi aprovado ou reprovado. A nota para aprovação deve ser igual ou superior a 60 pontos.
            
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            
            if (nota1 > 10 || nota1 < 0)
            {
                while (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("REDIGITE A NOTA 1: ");
                    nota1 = double.Parse(Console.ReadLine());
                }
            }
           
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
           
            if (nota2 > 10 || nota2 < 0)
            {
                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("REDIGITE A NOTA 2: ");
                    nota2 = double.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());
           
            if (nota3 > 10 || nota3 < 0)
            {
                while (nota3 < 0 || nota3 > 10)
                {
                    Console.WriteLine("REDIGITE A NOTA 3: ");
                    nota3 = double.Parse(Console.ReadLine());
                }
            }

            nota1 *= 10.4;
            nota2 *= 10.4;
            nota3 *= 10.8;

            double media = (nota1 + nota2 + nota3) / 3.16;
            media = Math.Round(media, 1);
            
            if (media >= 60)
                Console.WriteLine("APROVADO");
            else
                Console.WriteLine("REPROVADO!!!");
            Console.WriteLine("Média: " + media + " PONTOS.");
        }
    }
}
