using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Atividade
{
    class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            Console.WriteLine("_______________________________");
            base.setCor("azul");
            this.lado = lado;
            Console.WriteLine("Area do quadrado: " + this.calcularArea());
            Console.WriteLine("_______________________________");
        }

        public Quadrado(double lado, string cor)
        {
            Console.WriteLine("_______________________________");
            base.setCor(cor);
            this.lado = lado;
            Console.WriteLine("Area do quadrado: " + this.calcularArea());
            Console.WriteLine("_______________________________");
        }

        public override double calcularArea()
        {
            return lado * lado;
        }

        public override void digaOI(string msg)
        {
            Console.WriteLine("Oi: " + msg);
        }
    }
}
