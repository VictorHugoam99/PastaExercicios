using System;

namespace Aluno {
    class Program {
        static void Main (string[] args) {
            Aluno aluno1 = new Aluno ("Vitao", "789.456.321-21");
            Aluno aluno2 = new Aluno ("Cesar", "022.651.378-99", "Prog1");

            Console.WriteLine ("Nome: " + aluno1.Nome);
            Console.WriteLine ("CPF:" + aluno1.Cpf);
            Console.WriteLine ("Curso: " + aluno1.Curso);

            System.Console.WriteLine ();

            Console.WriteLine ("Nome: " + aluno2.Nome);
            Console.WriteLine ("CPF:" + aluno2.Cpf);
            Console.WriteLine ("Curso: " + aluno2.Curso);
            Console.WriteLine ();

            System.Console.WriteLine ("Entre com o Nome: ");
            string nome = Console.ReadLine ();
            System.Console.WriteLine ("Entre com o CPF: ");
            string cpf = Console.ReadLine ();
            System.Console.WriteLine ("Entre com o curso: ");
            string curso = Console.ReadLine ();
            System.Console.WriteLine ("Entre com a nota: ");
            int nota = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Entre com o bimestre: ");
            int bimestre = int.Parse (Console.ReadLine ());

            Aluno aluno3 = new Aluno (nome, cpf, curso);
            aluno3.setNotas (bimestre, nota);

            Console.WriteLine ("Nome: " + aluno3.Nome);
            Console.WriteLine ("CPF: " + aluno3.Cpf);
            Console.WriteLine ("Curso: " + aluno3.Curso);
            Console.WriteLine ("Notas: ");
            foreach (int n in aluno3.getNotas ()) {
                Console.WriteLine (n + " ");
            }
            Console.WriteLine ();

        }

    }
}