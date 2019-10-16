using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Violão.");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo de violão.");
            return true;
        }
    }
}