using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13_Atividade
{
    class Circulo : IForma
    {
        private double raio;

        public Circulo (double raio)
        {
            Console.WriteLine("\n\n---CIRCULO-----------------------------------");
            this.raio = raio;
            Console.WriteLine("---------------------------------------------");
        }

        public double calcularArea()
        {
            return Math.Round(Math.PI * (raio * raio), 2);
        }
    }
}
