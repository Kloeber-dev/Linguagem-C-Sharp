using System;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números inteiros: ");
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma desses números é: " + (num + num1 + num2));
        }
    }
}
