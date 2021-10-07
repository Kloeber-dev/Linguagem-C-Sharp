using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13_Atividade
{
    class Triangulo : IForma
    {
        private double altura;
        private double base_forma;

        public Triangulo (double base_forma, double altura)
        {
            Console.WriteLine("\n\n---TRIANGULO---------------------------------");
            this.altura = base_forma;
            this.base_forma = altura;
            Console.WriteLine("---------------------------------------------");
        }

        public double calcularArea()
        {
            return (altura * base_forma) / 2;
        }
    }
}
