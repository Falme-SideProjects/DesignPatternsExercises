using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ModoNormal : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("O Carro precisa abastecer uma vez");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversários devem correr na mesma velocidade");
        }
    }
}
