using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ModoDificil : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("Adicionar obstáculo na pista");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversário devem correr mais");
        }
    }
}
