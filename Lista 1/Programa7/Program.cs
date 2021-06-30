using System;

namespace Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            float Fahrenheit = float.Parse(Console.ReadLine());
            Console.WriteLine("A temperatura em Celsius é: " + (5.0 * (Fahrenheit - 32.0) / 9.0));
        }
    }
}
