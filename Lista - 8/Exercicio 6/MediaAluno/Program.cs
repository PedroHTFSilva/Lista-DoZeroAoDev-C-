using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Cadastro de Aluno");

        Console.Write("Digite o nome do aluno: ");
        String nome = Console.ReadLine();

        Console.Write("Digite o gênero do Aluno: ");
        string genero = Console.ReadLine();

        Console.WriteLine("Digite a idade do aluno: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        double somaNotas = 0;
        int quantidadesNotas = 4;

        Console.WriteLine($"Digite as {quantidadesNotas} notas do aluno: ");

        for (int i = 1; i <= quantidadesNotas; i++)
        {
            Console.Write($"{i} nota:");
            double nota = Convert.ToDouble(Console.ReadLine());
            somaNotas += nota;
        }

        double media = somaNotas / quantidadesNotas;

        Console.WriteLine("Resultados");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Gênero: {genero}");
        Console.WriteLine($"Idade:{idade}");
        Console.WriteLine($"Média:{media:F2}");

        if (idade < 10 && media >= 4)
        {
            Console.WriteLine("Situação: Aprovado!");
        }
        else if (idade > 10 && media >= 7)
        {
            Console.WriteLine("Situação: Aprovado");
        }
        else if (idade < 10 && media < 4)
        {
            Console.WriteLine("Situação: Reprovado");
        }
        else if (idade > 10 && media < 7)
        {
            Console.WriteLine("Situação: Reprovado");
        }
        else
        {
            Console.WriteLine("Situação: Não definida.");
        }
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();

        }
}