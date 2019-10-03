using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite seu Nome:");
            string Nome = Console.ReadLine();
            System.Console.WriteLine("Digite seu CPF:");
            string Cpf = Console.ReadLine();
            System.Console.WriteLine("Digite seu Email:");
            string Email = Console.ReadLine();
            
            Cliente cliente0 = new Cliente (Nome, Cpf, Email);

            bool trocouSenha = false;

            do
            {
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                
                trocouSenha = cliente0.TrocarSenha(senha);
            if (trocouSenha){
                System.Console.WriteLine("Senha alterada com sucesso!");
            } else {
                System.Console.WriteLine("Senha inválida");
            }
            } 
            while(!trocouSenha);

            Console.WriteLine("Agência:");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Número:");
            int numero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite seu Email:");
            string titular = Console.ReadLine();
            
            ContaCorrente conta0 = new ContaCorrente (agencia, numero, titular);

            bool trocouSenha = false;

            do
            {
                Console.Write("Saldo: ");
                double saldo = double.Parse(Console.ReadLine());
                
            if (saldo > 0) {
                System.Console.WriteLine("Conta criada com sucesso!");
            } else {
                System.Console.WriteLine("Saldo inválida");
            }
            } 
            while(saldo < 0);
        System.Console.WriteLine("Agência: " + conta0.Agencia);
        } 
          
    }       
}