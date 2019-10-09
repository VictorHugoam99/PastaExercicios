namespace SENAIzinho {
    public class Sala {
        public int capacidadeAtual;
        public int capacidadeTotal = 10;
        public int numeroSala;
        public string[] Alunos;

        public Sala (int numeroSala, int capacidadeTotal) {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
        }

        public string AlocarAluno (string[] Alunos) {

            if (capacidadeAtual < capacidadeTotal) 
            {
                System.Console.WriteLine ("Nome do aluno: ");
                string aluno = Console.ReadLine ();
                Alunos [capacidadeTotal- capacidadeAtual] = nomeAluno;
                capacidadeTotal = capacidadeAtual -1;
            } 
            else
            {
                System.Console.WriteLine ("Infelizmente a sala esta lotada :( !");
            }
        }
        public string RemoverAluno (string[] Alunos) {
            foreach (var aluno in Alunos) {
                if (true) {
                    Alunos.RemoveAt (aluno);
                } else {
                    System.Console.WriteLine ("Aluno não encontrado.");
                }
            }
        }

        public string MostrarAlunos () 
        {
            foreach (var item in Alunos)
            {
                
            }
        }

    }
}