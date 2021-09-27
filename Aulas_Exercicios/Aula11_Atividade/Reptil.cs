using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atividade
{
    public class Reptil : Animal
    {
        public Reptil()
        {
            this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            Console.WriteLine("São animais ectotérmicos e possuem o corpo recoberto por escamas e/ou placas ósseas\n\n");
        }
    }
}
