using System;

namespace Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            decimal num = decimal.Parse(Console.ReadLine());
            Console.WriteLine("A quinta parte desse número é: " + (num / 5));
        }
    }
}
