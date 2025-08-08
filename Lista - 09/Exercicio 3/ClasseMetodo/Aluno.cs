using System;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public List<double> Notas { get; set; } = new List<double>();

    public Aluno(string nome)
    {
        Nome = nome;
    }

    // Método público para adicionar nota
    public void AdicionarNota(double nota)
    {
        if (nota >= 0 && nota <= 10)
        {
            Notas.Add(nota);
            Console.WriteLine($"Nota {nota} adicionada para {Nome}.");
        }
        else
        {
            Console.WriteLine("Nota inválida. Digite uma nota entre 0 e 10.");
        }
    }

    // Método privado para calcular a média das notas
    private double CalcularMedia()
    {
        double soma = 0;
        foreach (double nota in Notas)
        {
            soma += nota;
        }
        return Notas.Count > 0 ? soma / Notas.Count : 0;
    }

    // Método público para verificar se o aluno foi aprovado
    public void VerificarAprovacao()
    {
        double media = CalcularMedia();
        if (media >= 7)
        {
            Console.WriteLine($"{Nome} foi aprovado com média {media:F2}.");
        }
        else
        {
            Console.WriteLine($"{Nome} foi reprovado com média {media:F2}.");
        }
    }
}