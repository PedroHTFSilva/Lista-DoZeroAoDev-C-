using System;
using System.Collections.Generic;

public class Pilha<T>
{
    private LinkedList<T> lista = new LinkedList<T>();

    // Push: Insere no topo (início da lista)
    public void Push(T item)
    {
        lista.AddFirst(item);
    }

    // Pop: Remove e retorna o topo
    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("A pilha está vazia!");

        T valor = lista.First.Value;
        lista.RemoveFirst();
        return valor;
    }

    // Peek: Consulta o topo sem remover
    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("A pilha está vazia!");

        return lista.First.Value;
    }

    // Verifica se está vazia
    public bool IsEmpty()
    {
        return lista.Count == 0;
    }

    // Retorna a quantidade de elementos
    public int Count()
    {
        return lista.Count;
    }

    // Exibe a pilha do topo para a base
    public void Mostrar()
    {
        Console.WriteLine("Estado atual da pilha (topo -> base):");
        foreach (T item in lista)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Pilha<char> pilha = new Pilha<char>();

        Console.WriteLine(">>> Empilhando 'A', 'B', 'C' na pilha...");
        pilha.Push('A');
        pilha.Push('B');
        pilha.Push('C');
        pilha.Mostrar();

        Console.WriteLine($">>> Pop realizado: {pilha.Pop()}");
        pilha.Mostrar();

        Console.WriteLine($">>> Peek do topo: {pilha.Peek()}");
        pilha.Mostrar();

        Console.WriteLine($">>> Total de elementos: {pilha.Count()}");

        Console.WriteLine("\nDesempilhando até esvaziar:");
        while (!pilha.IsEmpty())
        {
            Console.WriteLine($"Pop: {pilha.Pop()}");
        }

        Console.WriteLine("Pilha esvaziada.");
    }
}
