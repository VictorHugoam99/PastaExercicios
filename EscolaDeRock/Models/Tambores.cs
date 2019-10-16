using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Tocando acordes de violão");
            return true;
        }
    }
}