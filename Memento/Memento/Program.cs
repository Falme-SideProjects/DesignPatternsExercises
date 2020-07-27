﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Acao acao = new Acao();
            acao.Estado = "play";

            Armazena armazena = new Armazena();
            armazena.Memento = acao.CriarMemento();

            acao.Estado = "pause";
            acao.RestaurarEstado(armazena.Memento);

            Console.ReadKey();
        }
    }
}
