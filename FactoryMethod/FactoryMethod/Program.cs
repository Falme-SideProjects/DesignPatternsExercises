using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            Console.WriteLine("Selecione seu personagem");
            string escolha = Console.ReadLine();

            IPersonagem personagem = factoryMethod.Escolher_Personagem(escolha);

            Console.WriteLine();
            Console.WriteLine("Voce Vai jogar com : ");
            personagem.Escolhido();

            Console.ReadKey();

        }
    }
}
