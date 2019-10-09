using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteAlunos = 100;
            int limiteSalas = 10;
            Aluno [] Aluno = new Aluno[100];
            Sala [] Sala = new Sala[10];
            int alunosCadastrados;
            int salasCadastradas;
            bool querSair;

        }

        public void CadastrarAluno() {
            if ((limiteAlunos < 100) && (limiteSalas < 10))
            {
                System.Console.WriteLine("Nome : ");
                string nome = Console.ReadLine();
                System.Console.WriteLine("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());
                Aluno aluno1 = new Aluno(nome, idade);
            } else 
            {
                System.Console.WriteLine("Sem vagas disponíveis no momento");
            }
        }

        public void CadastrarSala() 
        {
            if (limiteSalas < 10)
            {
                System.Console.WriteLine( "Digite o número da sala: ");
                int numero = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite a idade: ");
                int cap = int.Parse(Console.ReadLine());
                Sala sala1 = new Sala(numero, cap);
            }else 
            {
                System.Console.WriteLine("Não temos espaço p/ novas salas.");
            }
        }

        public void AlocarAluno()
        {
            System.Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Digite a sala onde será registrado: ");
            int sala = int.Parse(Console.ReadLine());
            
            if ((nome = aluno1.Nome) && (sala = sala1.numeroSala))
            {
                System.Console.WriteLine( " ");
                int numero = int.Parse(Console.ReadLine());
                System.Console.WriteLine("D ");
                int cap = int.Parse(Console.ReadLine());
                Sala sala1 = new Sala(numero, cap);
            }else 
            {
                System.Console.WriteLine("Não temos espaço p/ novas salas.");
            }
        }
    }
}
