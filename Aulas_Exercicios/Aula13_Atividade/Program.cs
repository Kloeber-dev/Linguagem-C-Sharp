using System;

namespace Aula13_Atividade
{
    class Program
    {
        static void exibeArea(IForma figura)
        {
            Console.WriteLine("A área é de: " + figura.calcularArea());
        }
        static void Main(string[] args)
        {
            IForma figura = new Circulo(1.3);
            exibeArea(figura);

            figura = new Quadrado(2);
            exibeArea(figura);
            
            figura = new Retangulo(3, 6);
            exibeArea(figura);
            
            figura = new Triangulo(5, 6);
            exibeArea(figura);
        }
    }
}
