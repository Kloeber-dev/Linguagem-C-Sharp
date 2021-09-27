
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atividade
{
    public class Anfibio : Animal
    {
        public Anfibio()
        {
            this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            base.Caracteristicas();
            Console.Write("ANFÍBIOS\n");
            Console.WriteLine("São animais pecilotérmicos e possuem pele úmida e lisa para facilitar a respiração");
        }
    }
}
