using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Guitarra : InstrumentoMusical,IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Guitarra");
            return true;
        }
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo de guitarra");
            return true;
        }
    }
}