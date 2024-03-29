﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        public static Singleton instancia = null;

        public static Singleton GetInstancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Singleton();
                    Console.WriteLine("Bola em Jogo");
                }

                return instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
