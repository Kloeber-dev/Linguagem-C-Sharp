using System;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número real: ");
            decimal num = decimal.Parse(Console.ReadLine());
            Console.WriteLine("O número digitado foi: " + num);
        }
    }
}
