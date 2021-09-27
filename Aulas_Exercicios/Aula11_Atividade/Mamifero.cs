using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atividade
{
    public class Mamifero : Animal
    {
        public Mamifero()
        {
            this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            base.Caracteristicas(); 
            Console.Write("MAMÍFEROS\n");
            Console.WriteLine("São animais endotérmicos que possuem pelos e glândulas mamárias");
        }
    }
}
