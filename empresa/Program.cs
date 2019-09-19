using System;
namespace empresa
{
   class Program
   {
       static void Main(string[] args)
       {
           double salario;
           double percentual = 30.0 / 100.0;
           Console.Write("Digite seu salário: ");
           salario = double.Parse(Console.ReadLine());
           if (salario < 500)
           {
               salario = salario + (salario * percentual);
               Console.WriteLine("Seu novo salário é " + salario);
           }
           else
           {
               Console.WriteLine("Você ja ganha muito");
       }
   }
}
}