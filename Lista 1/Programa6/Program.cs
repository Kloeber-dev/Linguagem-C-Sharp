using System;

namespace Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            float Celsius = float.Parse(Console.ReadLine());
            Console.WriteLine("A temperatura em Fahrenheit é: " + (Celsius * (9.0 / 5.0) + 32.0));
        }
    }
}
