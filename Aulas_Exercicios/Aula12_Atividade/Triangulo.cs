using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Atividade
{
    class Triangulo : Forma
    {
        private double altura;
        private double base_triangulo;

        public Triangulo(double altura, double base_triangulo)
        {
            Console.WriteLine("_______________________________");
            base.setCor("amarelo");
            this.altura = altura;
            this.base_triangulo = base_triangulo;
            Console.WriteLine("Area do triangulo: " + this.calcularArea());
            Console.WriteLine("_______________________________");
        }

        public Triangulo(double altura, double base_triangulo, string cor)
        {
            Console.WriteLine("_______________________________");
            base.setCor(cor);
            this.altura = altura;
            this.base_triangulo = base_triangulo;
            Console.WriteLine("Area do Triangulo: " + this.calcularArea());
            Console.WriteLine("_______________________________");
        }

        public override double calcularArea()
        {
            return (altura * base_triangulo)/2;
        }

        public override void digaOI(string msg)
        {
            Console.WriteLine("Oi: " + msg);
        }
    }
}
