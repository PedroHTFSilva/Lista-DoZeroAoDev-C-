
using System;

class Program
{
    public static void Main(string[] args)
    {
        double[] notas = new double[4];

        Console.WriteLine("Digite as quatro notas do aluno:");

        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = LerNota($"Nota {i + 1}: ");
        }

        double media = CalcularMedia(notas);

        Console.WriteLine($"A média das notas é: {media}");
    }

    public static double LerNota(string mensagem)
    {
        double nota;
        while (true)
        {
            Console.Write(mensagem);
            if (double.TryParse(Console.ReadLine(), out nota))
            {
                return nota;
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor numérico válido.");
            }
        }
    }

    public static double CalcularMedia(double[] notas)
    {
        double soma = 0;
        foreach (double nota in notas)
        {
            soma += nota;
        }
        return soma / notas.Length;
    }
}
