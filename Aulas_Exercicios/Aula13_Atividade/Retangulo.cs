using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13_Atividade
{
    class Retangulo : IForma
    {
        private double altura;
        private double largura;

        public Retangulo (double altura, double largura)
        {
            Console.WriteLine("\n\n---RETANGULO---------------------------------");
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("---------------------------------------------");
        }

        public double calcularArea()
        {
            return largura * altura;
        }
    }
}
