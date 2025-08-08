using System;

class Program
{
    static void Main()
    {
        double somaNotas = 0;
        int quantidadeNotas = 4;

        Console.WriteLine("Digite as 4 notas do aluno:");

        for (int i = 1; i <= quantidadeNotas; i++)
        {
            Console.Write($"Nota {i}: ");
            double nota = Convert.ToDouble(Console.ReadLine());
            somaNotas += nota;
        }

        double media = somaNotas / quantidadeNotas;

        Console.WriteLine($"Média do aluno: {media:F2}");

        if (media >= 9)
        {
            Console.WriteLine("Aprovado com Sucesso");
        }
        else if (media >= 5)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
