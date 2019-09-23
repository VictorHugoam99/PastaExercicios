using System;

namespace FormasGeo
{
    class Program
    {
        static void Main(string[] args)
        {
           string oper, erro;
           double quadrado, triangulo, circulo, trapezio, retangulo, losango;
           double num1, num2, numx;
           double pi = 3.14;
           Console.WriteLine("Digite q para saber a area do quadrado");
           Console.WriteLine("Digite t para saber a area do triângulo");
           Console.WriteLine("Digite c para saber a area do círculo");
           Console.WriteLine("Digite tp para saber a area do trapézio");
           Console.WriteLine("Digite r para saber a area do retângulo");
           Console.WriteLine("Digite l para saber a area do losango");
           oper = Console.ReadLine();
           switch (oper) {
                   case "q":
                       Console.WriteLine("Digite a base");
                       num1 = double.Parse(Console.ReadLine());
                       Console.WriteLine("Digite a altura");
                       num2 = double.Parse(Console.ReadLine());
                       quadrado = num1 * num2;
                       Console.WriteLine(quadrado);
                   break;
                   case "t":
                       Console.WriteLine("Digite a base");
                       num1 = double.Parse(Console.ReadLine());
                       Console.WriteLine("Digite a altura");
                       num2 = double.Parse(Console.ReadLine());
                       triangulo = (num1 * num2) / 2;
                       Console.WriteLine(triangulo);
                   break;
                   case "c":
                       Console.WriteLine("Digite o raio");
                       num2 = double.Parse(Console.ReadLine());
                       circulo = pi * (num2 * num2);
                       Console.WriteLine(circulo);
                   break;
                   case "tp":
                       Console.WriteLine("Digite a base maior");
                       num1 = double.Parse(Console.ReadLine());
                       Console.WriteLine("Digite a base menor");
                       numx = double.Parse(Console.ReadLine());
                       Console.WriteLine("Digite a altura");
                       num2 = double.Parse(Console.ReadLine());
                       trapezio = ((num1 + numx) * num2) / 2;
                       Console.WriteLine(trapezio);
                   break;
                   case "r":
                       Console.WriteLine("Digite a base");
                       num1 = double.Parse(Console.ReadLine());
                       Console.WriteLine("Digite a altura");
                       num2 = double.Parse(Console.ReadLine());
                       retangulo = num1 * num2;
                       Console.WriteLine(retangulo);
                   break;
                   case "l":
                       Console.WriteLine("Digite o diâmetro maior");
                       num1 = double.Parse(Console.ReadLine());
                       Console.WriteLine("Digite o diâmetro menor");
                       num2 = double.Parse(Console.ReadLine());
                       losango = (num1 * num2) / 2;
                       Console.WriteLine(losango);
                   break;
                   default: erro = "Operação inválida";
                   Console.WriteLine(erro);
                   break;
                   }
       }
   }
}