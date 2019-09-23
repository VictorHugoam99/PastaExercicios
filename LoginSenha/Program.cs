using System;

namespace LoginSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string admLogin = "admin";
            string admPass = "admin";  

            Console.WriteLine("Entre com o usuário: ");
            string login = Console.ReadLine();
            Console.Write("Entre com a senha: ");
            string passwd = Console.ReadLine();

            if ((login == admLogin) && passwd == admPasswd) {
                Console.WriteLine("Bem vindo Admin.");
            } 
            else {
                Console.WriteLine("Olá usuário.");
            }
        }
    }
}
