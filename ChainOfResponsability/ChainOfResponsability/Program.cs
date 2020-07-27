using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Manipulador pA = new PersonagemA(),
                pB = new PersonagemB(),
                pC = new PersonagemC();

            pA.defineSucessor(pB);
            pB.defineSucessor(pC);

            int[] requisicoes = { 5, 8, 15, 20, 18, 3, 27, 20 };

            foreach(int req in requisicoes)
            {
                pA.Convoca(req);
            }

            Console.ReadKey();
        }
    }
}
