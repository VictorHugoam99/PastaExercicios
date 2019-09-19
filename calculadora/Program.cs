using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            string oper;

            System.Console.WriteLine("Digite o primeiro numero:");
            num1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o segundo numero:");
            num2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o operador");
            oper = Console.ReadLine();

            switch (oper)
            {
                case "+":
                    System.Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case "-":
                    System.Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case "*":
                    System.Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                case "/":
                    System.Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;

                case "%":
                    System.Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    break;


            }
        }
    }
}
