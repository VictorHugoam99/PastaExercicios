using System;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {

            #region Cadastro cliente

            Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            Console.Write ("Cpf: ");
            string cpf = Console.ReadLine ();
            Console.Write ("Email: ");
            string email = Console.ReadLine ();
            Cliente cliente0 = new Cliente (nome, cpf, email);

            bool trocouSenha = false;
            do {
                System.Console.Write ("Senha: ");
                string senha = Console.ReadLine ();
                trocouSenha = cliente0.TrocarSenha (senha);
                if (trocouSenha) {
                    System.Console.WriteLine ("Senha alterada com sucesso!");
                } else {
                    System.Console.WriteLine ("Senha inválida");
                }
            } while (!trocouSenha);
            #endregion
            Console.Clear ();

            Console.Write ("Agência: ");
            int agencia = int.Parse (Console.ReadLine ());
            Console.Write ("Número: ");
            int numero = int.Parse (Console.ReadLine ());

            ContaCorrente conta0 = new ContaCorrente (agencia, numero, cliente0);

            Cliente cliente1 = new Cliente ("Cesar", "123.123.123-12", "1@g.com");
            ContaCorrente conta1 = new ContaCorrente (10, 12312, cliente1);
            Cliente usuario = conta0.Titular;
            bool NovoDeposito = false;
            Console.Clear ();
            System.Console.WriteLine ("ByteBank - Depósito em conta");
            System.Console.WriteLine ($"Bem Vindo - {usuario.Nome}");
            System.Console.WriteLine ($"Agência {conta0.Agencia} Conta: {conta0.Numero}");
            System.Console.WriteLine ($"Saldo: {conta0.Saldo}$");
            System.Console.WriteLine ();
            System.Console.Write ("Digite o valor do depósito: ");
            double deposito = double.Parse (Console.ReadLine ());
            NovoDeposito = conta0.DepositarSaldo (deposito);

            if (NovoDeposito) {
                System.Console.WriteLine ("Depósito realizado com sucesso!");
                System.Console.WriteLine ("Saldo: " + conta0.Saldo + "$");
            } else {
                System.Console.WriteLine ("Valor inválido");
            }
            System.Console.WriteLine ("Enter para continuar");
            Console.ReadLine ();

            bool NovoSaque = false;
            Console.Clear ();
            System.Console.WriteLine ("ByteBank - Depósito em conta");
            System.Console.WriteLine ($"Bem Vindo - {usuario.Nome}");
            System.Console.WriteLine ($"Agência {conta0.Agencia} Conta: {conta0.Numero}");
            System.Console.WriteLine ($"Saldo: {conta0.Saldo}$");
            System.Console.WriteLine ();
            System.Console.Write ("Digite o valor do saque: ");
            double saque = double.Parse (Console.ReadLine ());
            NovoSaque = conta0.Saque (saque);

            if (NovoSaque) {
                System.Console.WriteLine ("Saque realizado com sucesso!");
                System.Console.WriteLine ("Saldo: " + conta0.Saldo + "$");
            } else {
                System.Console.WriteLine ("Valor inválido");
            }
            System.Console.WriteLine ("Enter para continuar");
            Console.ReadLine ();

            Console.Clear ();
            System.Console.WriteLine ("ByteBank - Depósito em conta");
            System.Console.WriteLine ($"Bem Vindo - {usuario.Nome}");
            System.Console.WriteLine ($"Agência {conta0.Agencia} Conta: {conta0.Numero}");
            System.Console.WriteLine ($"Saldo: {conta0.Saldo}$");
            System.Console.WriteLine ();
            System.Console.Write ("Digite o valor da tranferência: ");
            double transf = double.Parse (Console.ReadLine ());

            if (conta0.transferencia (conta1, transf)) {
                System.Console.WriteLine ("Transferência realizada com sucesso");
                System.Console.WriteLine (" Seu Saldo: " + conta0.Saldo + "$");
                System.Console.WriteLine ("Saldo do destinatário: " + conta1.Saldo + "$");
            } else {
                System.Console.WriteLine ("Valor inválido");
            }
        }
    }
}