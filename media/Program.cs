using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            float Nota1 = 0;
            float Nota2 = 0;
            float Nota3 = 0;
            float Nota4 = 0;    
            float media = 0;

            Console.WriteLine("Digite sua 1° nota:");
            Nota1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite sua 2° nota:");
            Nota2 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite sua 3° nota:");
            Nota3 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite sua 4° nota:");
            Nota4 = float.Parse(Console.ReadLine());


          media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            
            if(media > 7.0){
                System.Console.WriteLine("Parabéns você passou");
            }
            else if (media == 7.0){
                System.Console.WriteLine("Passou raspando!");
            }
            else {
                System.Console.WriteLine("Que pena, você reprovou, estude mais!");
            }



        }
    }
}
