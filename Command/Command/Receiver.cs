using System;

namespace Command
{
    public class Receiver
    {
        internal void PrimeiroPedido(string a)
        {
            Console.WriteLine("Comando Recebido: " + a);
        }

        internal void SegundoPedido(string b)
        {
            Console.WriteLine("Outro Comando Recebido: " + b);
        }
    }
}