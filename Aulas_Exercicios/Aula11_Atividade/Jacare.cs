using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atividade
{
    class Jacare : Reptil
    {
        public Jacare()
        {
            //    this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            Console.WriteLine("São animais ectotérmicos e possuem o corpo recoberto por escamas e/ou placas ósseas");
            Console.WriteLine("O som emitido pelo jacaré é: BRAMIDO\n\n");
        }
    }
}


