using System;
using System.Collections.Generic;

class Program
{
    static List<string> tarefas = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Lista de Tarefas ====");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarTarefa();
                    break;
                case "2":
                    ListarTarefas();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void AdicionarTarefa()
    {
        Console.Write("Digite a tarefa: ");
        string tarefa = Console.ReadLine();
        tarefas.Add(tarefa);
        Console.WriteLine("Tarefa adicionada!");
    }

    static void ListarTarefas()
    {
        Console.WriteLine("Tarefas:");
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa adicionada.");
        }
        else
        {
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }
        }
    }
}
