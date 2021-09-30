using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Atividade
{
    abstract class Forma
    {
        private string cor;

        protected void setCor(string cor)
        {
            this.cor = cor;
            Console.WriteLine("Cor da forma: " + this.cor);
        }

        public abstract double calcularArea();
        public abstract void digaOI(string msg);
    }
}
