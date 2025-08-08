using System;
using System.Collections.Generic;

class Program
{
    static void MostrarPilha(Stack<char> pilha)
    {
        Console.WriteLine("Estado atual da pilha (do topo para a base):");
        foreach (char c in pilha)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine("\n");
    }

    static void Main()
    {
        Stack<char> pilha = new Stack<char>();

        string frase = "Do Zero ao Dev";

        Console.WriteLine(">>> Empilhando letra a letra: \"Do Zero ao Dev\"");
        foreach (char c in frase)
        {
            pilha.Push(c);
        }
        MostrarPilha(pilha);

        Console.WriteLine(">>> Realizando 2 POPs:");
        for (int i = 0; i < 2; i++)
        {
            char removido = pilha.Pop();
            Console.WriteLine($"Elemento removido: {removido}");
        }
        MostrarPilha(pilha);

        Console.WriteLine(">>> Empilhando letra a letra: \"2022\"");
        string ano = "2022";
        foreach (char c in ano)
        {
            pilha.Push(c);
        }
        MostrarPilha(pilha);

        Console.WriteLine(">>> Desempilhando e exibindo o resultado final:");
        while (pilha.Count > 0)
        {
            Console.Write(pilha.Pop());
        }

        Console.WriteLine("\n\nPrograma finalizado.");
    }
}
