using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Controle controle = new Controle();
            controle.EnviarComandoSimples(new SimplesComando("Dizer oi"));

            Receiver receiver = new Receiver();
            controle.EnviarComandoComplexo(new ComplexoComando(receiver, "Abastecer Carro", "Calibrar os pneus do carro"));

            controle.Fazer();

            Console.ReadKey();
        }
    }
}
