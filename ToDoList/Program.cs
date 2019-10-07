using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todoitem> todoList = new List<Todoitem>();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;

            try {
                string [] todoFile = File.ReadAllLines(filePath);

                foreach (var line in todoFile)
                {
                    string[] itens = line.Split(",");
                    string titulo = itens[0].Replace("\"", "");
                    string nota = itens[1].Replace("\"", "");

                    Todoitem todoitem = new Todoitem(titulo, nota);
                    todoList.Add(todoitem);
                }
            } catch (IOException ioe){
                System.Console.WriteLine("Erro ao acessar arquivo");
                System.Console.WriteLine(ioe.Message);
            }

            int opcao = 0;
            
            do
            {
                Console.Clear();
                System.Console.WriteLine("TODO LIST");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine();
                System.Console.WriteLine("Digite uma opção: ");
                System.Console.WriteLine("1 - Adicionar Item");
                System.Console.WriteLine("2 - Remover Item");
                System.Console.WriteLine("3 - Sair do programa");
                System.Console.WriteLine("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        AddItem (todoList);
                    break;
                    
                    case 2:
                        RemoveItem (todoList);
                        break;
                        
                    case 3:
                    System.Console.WriteLine("Tchau!");
                    break;
                    default:
                    System.Console.WriteLine("Opção Inválida");
                    Console.ReadLine();
                    break;
                
                } 

            } while(opcao != 3);
        }

        public static void ListaItens(List<Todoitem> todoList)
        {
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("Todo List");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID{"",2} Titulo{"",12} Notas");
            foreach (Todoitem item in todoList)
            {
                System.Console.WriteLine($"{count, 3}: {item.Titulo,-15} - {item.Nota}");
                count++;
            }
        }

    public static void AddItem (List<Todoitem> todoList)
    {
        Console.Clear();
        System.Console.WriteLine("NovoItem: ");
        System.Console.WriteLine();
        System.Console.WriteLine("Titulo: ");
        string titulo = Console.ReadLine();
        System.Console.WriteLine("Nota: ");
        string nota = Console.ReadLine();
        Todoitem item = new Todoitem (titulo, nota);

        todoList.Add(item);
    }

    public static void RemoveItem(List<Todoitem> todoList)
    {
        int index = 0;
        do {
                Console.Clear();
                System.Console.WriteLine("Remove item");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine("Digite o ID ou x para terminar");
                System.Console.WriteLine("ID: ");
                string id = Console.ReadLine();
                
                if (id.ToLower() == "x")
                {
                    break;
                }
                else {
                    index = int.Parse(id) - 1;
                }

                if ((index < 0) || (index > todoList.Count - 1))
                {
                    System.Console.WriteLine("ID inválido");
                    System.Console.WriteLine("Pressione <enter> para continuar");
                    Console.ReadLine();
                } else {
                    todoList.RemoveAt(index);
                }

        } while (true);
    }
    }
}

