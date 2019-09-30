using System;

namespace MateODragao.Models {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            do {

                Console.Clear ();
                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("        Mate o Dragão!");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine (" 1 - Iniciar jogo");
                System.Console.WriteLine (" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear ();
                        Guerreiro guerreiro = new Guerreiro ();
                        guerreiro.Nome = "Paulinho";
                        guerreiro.Sobrenome = "Tripa";
                        guerreiro.CidadeNatal = "Akodis";
                        guerreiro.DataNascimento = DateTime.Parse ("25/12/1490");
                        guerreiro.FerramentaAtaque = "Espada";
                        guerreiro.FerramentaProtecao = "Grimório";
                        guerreiro.Forca = 5;
                        guerreiro.Destreza = 1;
                        guerreiro.Inteligencia = 5;
                        guerreiro.Vida = 50;

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Draguinho";
                        dragao.Forca = 5;
                        dragao.Destreza = 5;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /*INICIO - Primeiro Diálogo */
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:{dragao.Nome}, seu louco! Vim-lhe derrotar-lhe");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Humano tolinho Quem pensa que és ?");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();
                        /*FIM - Primeiro Diálogo */

                        /*INICIO - Segundo Diálogo */
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, ó criatura morfética");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? Bom, que seja... fritar-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine ("BAMBAM: Tá na hora do show!");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        /*FIM - Segundo Diálogo */

                        Console.Clear ();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        bool jogadorNaoCorreu = true;
                       
                        if (jogadorAtacaPrimeiro) {
                            System.Console.WriteLine ("** Turno do Jogador **");
                            System.Console.WriteLine ("Escolha uma ação:");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto MALDJEETO! BIRRRLL");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errou otário!");
                                    }
                                    break;
                                    case "2":

                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora fii!");
                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EZ");
                            jogadorNaoCorreu = false;
                                break;
                            }
                        }
                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        
                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {   Console.Clear();
                            Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (dragaoDestrezaTotal > guerreiroDestrezaTotal ) {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Fritou o forévis, foi ?");
                                        guerreiro.Vida -= dragao.Forca;
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errou DESGRAÇADO!");
                                    }
                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        Console.Clear();
                        
                         System.Console.WriteLine ("** Turno do Jogador **");
                            System.Console.WriteLine ("Escolha uma ação:");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto MALDJEETO! BIRRRLL");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errou otário!");
                                    }
                                    break;
                                    case "2":

                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora fii!");
                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EZ");
                            jogadorNaoCorreu = false;
                                break;
                            }
                        
                        }
                        break;

                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine ("GAME OVER");
                        break;

                    default:
                        System.Console.WriteLine ("Comando inválido!");
                        break;
                }
            } while (jogadorNaoDesistiu);

        }
    }
}