using System;

namespace Aula12_Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
           Quadrado quad1 = new Quadrado(15.0);
           Quadrado quad2 = new Quadrado(10.0, "vermelho");
            Circulo circ1 = new Circulo(4.2);
            Circulo circ2 = new Circulo(4, "Rosa");
            Triangulo tri1 = new Triangulo(4, 1);
            Triangulo tri2 = new Triangulo(8, 1, "Roxo");
            Retangulo ret1 = new Retangulo(6, 6);
            Retangulo ret2 = new Retangulo(3, 6, "Turquesa");

        }
    }
}
