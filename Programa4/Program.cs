using System;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número real: ");
            decimal num = decimal.Parse(Console.ReadLine());
            Console.WriteLine("O quadrado desse número é: " + (num * num));
        }
    }
}
