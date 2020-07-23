using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var exercito = new Exercito();
            CriadorDeSoldado criadorDeSoldado;
            Soldado soldado;

            criadorDeSoldado = new CriadorDeForcasEspeciais();
            exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado com as caracteristicas: {0}, {1}, {2}",
                                soldado.Arma, soldado.Transporte, soldado.Foco);

            criadorDeSoldado = new CriadorDeInfantariaLeve();
            exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado com as caracteristicas: {0}, {1}, {2}",
                                soldado.Arma, soldado.Transporte, soldado.Foco);

            Console.ReadKey();

        }
    }
}
