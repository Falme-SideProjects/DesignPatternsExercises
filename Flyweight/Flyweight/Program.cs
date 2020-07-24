using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Flyweight flyweight = new Flyweight();
            string cor = string.Empty;

            Tartaruga tartaruga;

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Qual tartaruga enviar par a tela: ");
                cor = Console.ReadLine();

                tartaruga = flyweight.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
