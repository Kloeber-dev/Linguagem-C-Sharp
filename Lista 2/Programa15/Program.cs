using System;

namespace Programa15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia a idade e o tempo de serviço de um trabalhador e escreva se ele pode ou não se aposentar. As condições para aposentadoria são:
            //• Ter pelo menos 65 anos;
            //• Ou ter trabalhado pelo menos 30 anos;
            //• Ou ter pelo menos 60 anos e trabalhado pelo menos 25 anos.

            Console.WriteLine("=== APOSENTADORIA ===\n");

            Console.WriteLine("Digite a idade: ");
            byte idade = byte.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tempo de serviço (em anos): ");
            double tempo_servico = double.Parse(Console.ReadLine());

            if ((idade >= 65) || (tempo_servico >= 30.0))
            {
                Console.WriteLine("POSSUI DIREITO À APOSENTADORIA!");
            }
            else if ((idade >= 60) && (tempo_servico >= 25.0))
                Console.WriteLine("POSSUI DIREITO À APOSENTADORIA!");
            else
                Console.WriteLine("NÃO POSSUI DIREITO À APOSENTADORIA!");

        }
    }
}
