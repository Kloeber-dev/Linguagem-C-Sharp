using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Atividade
{
    class Retangulo : Forma
    {
        private double altura;
        private double largura;

        public Retangulo(double altura, double largura)
        {
            Console.WriteLine("_______________________________");
            base.setCor("laranja");
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Area do retangulo: " + this.calcularArea());
            Console.WriteLine("_______________________________");
        }

        public Retangulo(double altura, double largura, string cor)
        {
            Console.WriteLine("_______________________________");
            base.setCor(cor);
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Area do retangulo: " + this.calcularArea());
            Console.WriteLine("_______________________________");
        }

        public override double calcularArea()
        {
            return altura * largura;
        }

        public override void digaOI(string msg)
        {
            Console.WriteLine("Oi: " + msg);
        }
    }
}
