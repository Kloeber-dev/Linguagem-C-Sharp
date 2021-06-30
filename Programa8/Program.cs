using System;

namespace Programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Kelvin: ");
            double kelvin = double.Parse(Console.ReadLine());
            Console.WriteLine("A temperatura em Celsius é: " + (kelvin - 273.15));
        }
    }
}
