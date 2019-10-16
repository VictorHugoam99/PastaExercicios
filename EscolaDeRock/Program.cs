using System;
using EscolaDeRock.Models;
using System.Collections.Generic;
using EscolaDeRock.Interface;

namespace EscolaDeRock
{

    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentosEnum : int
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    };

    enum CategoriaEnum : int
    {
        HARMONIA,
        PERCUSSÃO,
        MELODIA
    };
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = true;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(FormacaoEnum));

            var opcoesFormacao = new List<string>()
            {
                "   -0                  ",
                "   -1                  "
            };
            int opcaoFormacaoSelecionada = 0;
            string menuBar = "==============";

            do 
            {
                bool formacaoEscolhida = false;
                do
                {
                    #region Area do menu
                    Console.Clear();
                    Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("    Seja Bem-vind@!        ");
                    Console.WriteLine("    Escolha uma formação:  ");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine(menuBar);

                    for (int i = 0; i< opcoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipal[i];
                        if(opcaoFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine (opcoesFormacao[opcaoFormacaoSelecionada].Replace("-",">").Replace(i.ToString(),titulo));
                            Console.ResetColor();
                        }else
                        {
                            System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                        }
                    }
                    var key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                                opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count -1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.Enter:
                        formacaoEscolhida = true;
                        break;
                    }
                    
                }while(!formacaoEscolhida);
            }while(!querSair);
         #endregion   
        }
    }
}