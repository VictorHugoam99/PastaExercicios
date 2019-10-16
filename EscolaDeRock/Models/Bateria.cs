using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Bateria : InstrumentoMusical, IPercussao
    {   
        public bool ManterRitmo()
        {
        System.Console.WriteLine("Mantendo o ritmo da Bateria");
        return true;
        }
    }
}