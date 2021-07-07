using System;

namespace Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia o salário de um trabalhador e o valor da prestação de um empréstimo. Se a prestação for maior que 20% do salário imprima: Empréstimo não concedido, caso contrário imprima: Empréstimo concedido.
            
            Console.WriteLine("Digite o sálario: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da prestação: ");
            double prestacao = double.Parse(Console.ReadLine());

            double porcentagem = salario * 0.20;

            if (prestacao > porcentagem)
                Console.WriteLine("Empréstimo Não Concedido!");
            else
                Console.WriteLine("Empréstimo Concedido!");
        }
    }
}
