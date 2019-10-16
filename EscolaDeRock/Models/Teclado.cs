using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
        public class Teclado : InstrumentoMusical, IHarmonia, IMelodia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando teclas do teclado");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do teclado.");
            return true;
        }
    }
}
