using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Cody cody = new Cody();

            Inimigo inimigo1 = new Inimigo(cody);
            Inimigo inimigo2 = new Inimigo(cody);
            Inimigo inimigo3 = new Inimigo(cody);

            while(true)
            {
                Console.WriteLine("Acertar o Cody com um golpe (S ou N) ?");

                if (Console.ReadLine() == "s")
                    cody.Golpe_Acertado(true);
                else
                    Console.WriteLine("Você não acertou o cody");
            }
        }
    }
}
