using System;
using System.Collections.Generic;

class Program
{
    static List<string> tarefas = new List<string>();

    static void Main()
    {
        // Console.Clear(); <-- Pode causar problema em alguns ambientes
        while (true)
        {
            Console.Clear(); // <-- Se ainda quiser usar, garanta que seu ambiente suporte
            Console.WriteLine("==== Lista de Tarefas ====");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Remover tarefa");
            Console.WriteLine("4. Sair");
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
                    RemoverTarefa();
                    break;
                case "4":
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

    static void RemoverTarefa()
    {
        ListarTarefas();
        Console.Write("Digite o número da tarefa que deseja remover: ");
        if (int.TryParse(Console.ReadLine(), out int indice))
        {
            if (indice >= 1 && indice <= tarefas.Count)
            {
                tarefas.RemoveAt(indice - 1);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}