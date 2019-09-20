using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            do {
            
            Console.WriteLine("Digite um número:");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 != 0){

                Console.WriteLine(" Seu número é impar.");
                
            } else {
                Console.WriteLine(" Seu número é par.");
            }
        }while (num1 != 0);
            
            
        }
    }  
}   