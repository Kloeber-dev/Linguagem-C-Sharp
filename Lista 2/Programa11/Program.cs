using System;

namespace Programa11
{
    class Program
    {
        static void Main(string[] args)
        {
            //A nota final de um estudante é calculada a partir de três notas atribuídas entre o intervalo de 0 ate 10, respectivamente, a um trabalho de laboratório, a uma avaliação ao semestral e a um exame final. A média das três notas mencionadas anteriormente obedece aos pesos: Trabalho de Laboratório: 2; Avaliação Semestral: 3; Exame Final: 5. De acordo com o resultado, mostre na tela se o aluno esta reprovado (média entre 0 e 2,9), de recuperação (média entre 3 e 4,9) ou se foi aprovado (média entre 5 e 10). Faça todas as verificações necessárias.

            Console.WriteLine("Digite a nota do Trabalho de Laboratório");
            double nota1 = double.Parse(Console.ReadLine());

            if (nota1 < 0 || nota1 > 10)
            {
                while (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("REDIGITE A NOTA DO TRABALHO DE LABORATÓRIO: ");
                    nota1 = double.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Digite a nota do Avaliação Semestral");
            double nota2 = double.Parse(Console.ReadLine());
            
            if (nota2 < 0 || nota2 > 10)
            {
                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("REDIGITE A NOTA DA AVALIAÇÃO SEMESTRAL: ");
                    nota2 = double.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Digite a nota do Exame Final");
            double nota3 = double.Parse(Console.ReadLine());
            
            if (nota3 < 0 || nota3 > 10)
            {
                while (nota3 < 0 || nota3 > 10)
                {
                    Console.WriteLine("REDIGITE A NOTA DO EXAME FINAL: ");
                    nota3 = double.Parse(Console.ReadLine());
                }
            }

            nota1 *= 1.6;
            nota2 *= 2.4;
            nota3 *= 4.0;

            double media = (nota1 + nota2 + nota3) / 8;
            if (media <= 2.9)
                Console.WriteLine("ALUNO REPROVADO!");
            else if (media < 5)
                Console.WriteLine("ALUNO DE RECUPERAÇÃO!");
            else
                Console.WriteLine("ALUNO APROVADO!");

            Console.WriteLine("A Média do Aluno é de: " + media);
        }
    }
}
