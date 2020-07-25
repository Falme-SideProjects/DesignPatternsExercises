using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Mochila mochila = new Mochila(new Corda(), new Binoculos(), new Machado());
            mochila.Interpretar(new Contexto());
            Console.ReadKey();
        }
    }
}
