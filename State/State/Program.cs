﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexto contexto = new Contexto(new PersonagemA());

            contexto.Troca();
            contexto.Troca();
            contexto.Troca();
            contexto.Troca();

            Console.ReadKey();

        }
    }
}
