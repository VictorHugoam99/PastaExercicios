using System;

namespace Aluno
{
    public class Aluno{
        //Propriedades
        public string Nome{get;set;}
        public string Curso{get;set;}
        public string Cpf{get;set;}
        public int [] Notas;

        //construtor 
        public Aluno(string Nome, string Cpf){
            this.Nome = Nome;
            this.Cpf = Cpf;        
        }
        public Aluno(string Nome, string Cpf, string Curso) {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Curso;
        } 
        //Metodos de acesso
        public void setNotas(int bi, int nota){
            int i = bi -1;
            if ((i < 0) || (i > 3)){
                //Condição de Erro;
                throw new ArgumentOutRangeExcption($"{nameof(Notas)} must be between 1 and 4");
            
            }else if(nota < 0 || Notas > 10){
                
                throw new ArgumentOutRangeExcption($"{nameof(Notas)} must be between 0 and 10");
            }
        }
    }
}