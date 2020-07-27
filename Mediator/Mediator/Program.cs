using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            MediadorConcreto mediador = new MediadorConcreto();

            Jogador1 j1 = new Jogador1(mediador);
            Jogador2 j2 = new Jogador2(mediador);

            mediador.Jogador1 = j1;
            mediador.Jogador2 = j2;

            j1.Enviar("Essa Partida foi muito boa!");
            j2.Enviar("foi sensasional. Conseguimos uma otima pontuacao");

            Console.ReadKey();
        }
    }
}
