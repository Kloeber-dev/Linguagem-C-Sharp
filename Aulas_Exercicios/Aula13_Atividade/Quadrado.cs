using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13_Atividade
{
    class Quadrado : IForma
    {
        private double lado;

        public Quadrado (double lado)
        {
            Console.WriteLine("\n\n---QUADRADO----------------------------------");
            this.lado = lado;
            Console.WriteLine("---------------------------------------------");
        }

        public double calcularArea()
        {
            return Math.Pow(lado, 2);
        }
    }
}
