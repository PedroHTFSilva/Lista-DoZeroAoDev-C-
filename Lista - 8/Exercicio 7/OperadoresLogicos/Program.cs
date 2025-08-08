using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sistema de Avaliação ===");

        Console.Write("Digite a idade do aluno: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a nota do aluno: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n=== Resultado ===");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Nota: {nota}");

        // Usando && (E lógico)
        if (idade >= 18 && nota >= 7)
        {
            Console.WriteLine("Aprovado para a faculdade.");
        }

        // Usando || (OU lógico)
        if (idade < 18 || nota >= 9)
        {
            Console.WriteLine("Pode tentar bolsa de estudos.");
        }

        // Usando ! (NÃO lógico)
        if (!(nota >= 5))
        {
            Console.WriteLine("Reprovado.");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

