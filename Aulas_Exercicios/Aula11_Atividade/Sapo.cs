using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atividade
{
    public class Sapo : Anfibio
    {
        public Sapo()
        {
            //    this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            Console.WriteLine("São animais pecilotérmicos e possuem pele úmida e lisa para facilitar a respiração cutânea");
            Console.WriteLine("O som emitido pelo jacaré é: COAXADO\n\n");
        }
    }
}
