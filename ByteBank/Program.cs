using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {   
            #region Cadastro Cliente.

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
            
            #endregion
            
            while(!trocouSenha);

            Console.WriteLine("Agência: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Conta: ");
            int numero = int.Parse(Console.ReadLine());
            
            
            ContaCorrente conta0 = new ContaCorrente (agencia, numero, cliente0);

            double saldo;

            do
            {
                Console.Write("Saldo: ");
                saldo = double.Parse(Console.ReadLine());
                
            if (saldo > 0) {
                conta0.Saldo = saldo;
                
            } else {
                System.Console.WriteLine("Saldo inválida");
            }
            } 
            while(saldo < 0);
            Console.WriteLine();
        }  

        Cliente cliente1 = new Cliente("cesar","123.123.123-65", "1@asd.com");
        ContaCorrente contaCorrente1 = new ContaCorrente (123,332,cliente1);

        #region Depósito.
        Cliente usuario = contaCorrente1.Titular;
        Console.WriteLine("ByteBank - Depósito em conta");
        System.Console.WriteLine($"Bem vindo - {usuario.Nome}");
    }       
}