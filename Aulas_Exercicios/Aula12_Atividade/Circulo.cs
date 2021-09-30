using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Atividade
{
    class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            Console.WriteLine("_______________________________");
            base.setCor("roxo");
            this.raio = raio;
            Console.WriteLine("---Considerando 'Pi' como sendo 3,14");
            Console.WriteLine("Area do circulo: " + this.calcularArea());
            Console.WriteLine("_______________________________");
        }

        public Circulo(double raio, string cor)
        {
            Console.WriteLine("_______________________________");
            base.setCor(cor);
            this.raio = raio;
            Console.WriteLine("---Considerando 'Pi' como sendo 3,14");
            Console.WriteLine("Area do circulo: " + this.calcularArea());
            Console.WriteLine("_______________________________");
        }

        public override double calcularArea()
        {
            return 2 * raio * 3.14;
        }

        public override void digaOI(string msg)
        {
            Console.WriteLine("Oi: " + msg);
        }
    }
}
