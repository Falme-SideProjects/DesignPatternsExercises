using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate colecaodeFases = new Aggregate();

            colecaodeFases[0] = "Fase 1";
            colecaodeFases[1] = "Fase 2";
            colecaodeFases[2] = "Fase 3";
            colecaodeFases[3] = "Fase 4";
            colecaodeFases[4] = "Fase 5";

            IIterator itterator = colecaodeFases.GetIterator();

            for (string s = itterator.primeiroItem; itterator.estaPronto == false; s = itterator.proximoItem)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
