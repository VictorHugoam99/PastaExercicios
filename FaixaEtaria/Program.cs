using System;

namespace FaixaEtaria
{
    class Program
    {
        static void Main(string[] args)
        {
           int ano = 0;
           int idade = 0;

           do 
           {
            Console.WriteLine("Qual o ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());
 
           }  while((ano > 2019) || (ano < 0));
        
            
           idade = 2019 - ano;

           if(idade < 3) {
               Console.WriteLine("Recem Nascido");
           } else if((idade >= 3) && (idade <= 11)){
               Console.WriteLine("Criança");
           }else if((idade >= 12) && (idade <= 19)){
               Console.WriteLine("Adolescente");
           }else if((idade >= 20) && (idade <= 65)){
               Console.WriteLine("Adulto");
           }else if(idade > 65){
               Console.WriteLine("Idoso");
           }
           
        }
    }
}
