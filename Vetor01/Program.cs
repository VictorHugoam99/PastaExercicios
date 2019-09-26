using System;
namespace matriz {
   class Program {
       static void Main (string[] args) {
           int[] vetor = new int[6];
           int k = 0;
           int j = 0;
           for (int i = 0; i <= 5; i++) {
               Console.Write ("Digite o " + (i + 1) + "º número: ");
               vetor[i] = int.Parse (Console.ReadLine ());
               if (vetor[i] % 2 != 0)
               {
                   k ++ ;
               } else
               {
                   ++ j;
               }
           }
               Console.WriteLine(k + " Números ímpares");
               Console.WriteLine(j + " Números pares");
       }
   }
}