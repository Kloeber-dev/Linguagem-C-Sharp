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
            base.Caracteristicas();
            Console.WriteLine("O som emitido pelo jacaré é: COAXADO\n\n");
        }
    }
}
