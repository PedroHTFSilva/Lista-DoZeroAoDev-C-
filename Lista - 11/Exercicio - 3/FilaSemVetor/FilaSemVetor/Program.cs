
// Classe Fila
public class Fila<T>
{
    private LinkedList<T> lista = new LinkedList<T>();

    // Enqueue: adiciona no final
    public void Enqueue(T item)
    {
        lista.AddLast(item);
    }

    // Dequeue: remove e retorna o primeiro elemento (frente)
    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("A fila está vazia!");

        T valor = lista.First.Value;
        lista.RemoveFirst();
        return valor;
    }

    // Peek: consulta o primeiro elemento sem remover
    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("A fila está vazia!");

        return lista.First.Value;
    }

    // Verifica se está vazia
    public bool IsEmpty()
    {
        return lista.Count == 0;
    }

    // Retorna o tamanho da fila
    public int Count()
    {
        return lista.Count;
    }

    // Exibe a fila
    public void Mostrar()
    {
        Console.WriteLine("Estado atual da fila (frente -> fim):");
        foreach (T item in lista)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

// Programa de teste
class Program
{
    static void Main()
    {
        Fila<string> fila = new Fila<string>();

        Console.WriteLine(">>> Enfileirando: Pedro, Ana, João");
        fila.Enqueue("Pedro");
        fila.Enqueue("Ana");
        fila.Enqueue("João");
        fila.Mostrar();

        Console.WriteLine($">>> Dequeue realizado: {fila.Dequeue()}");
        fila.Mostrar();

        Console.WriteLine($">>> Peek (frente da fila): {fila.Peek()}");
        fila.Mostrar();

        Console.WriteLine($">>> Total de elementos na fila: {fila.Count()}");

        Console.WriteLine("\nDesenfileirando até esvaziar:");
        while (!fila.IsEmpty())
        {
            Console.WriteLine($"Dequeue: {fila.Dequeue()}");
        }

        Console.WriteLine("Fila esvaziada.");
    }
}