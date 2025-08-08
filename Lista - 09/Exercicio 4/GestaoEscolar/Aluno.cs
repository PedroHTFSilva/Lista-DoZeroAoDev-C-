class Aluno
{
    public string Nome { get; set; }
    public List<double> Notas { get; set; } = new List<double>();

    public Aluno(string nome)
    {
        Nome = nome;
    }

    // Método público para adicionar notas
    public void AdicionarNota(double nota)
    {
        if (nota >= 0 && nota <= 10)
        {
            Notas.Add(nota);
            Console.WriteLine($"Nota {nota} adicionada para {Nome}.");
        }
        else
        {
            Console.WriteLine("Nota inválida, insira entre 0 e 10.");
        }
    }

    // Método privado para exibir situação do aluno
    private void ExibirSituacao(double media, bool aprovado)
    {
        if (aprovado)
        {
            Console.WriteLine($"{Nome} foi aprovado com média {media:F2}.");
        }
        else
        {
            Console.WriteLine($"{Nome} foi reprovado com média {media:F2}.");
        }
    }

    // Método público para calcular e exibir situação usando Calculo
    public void CalcularSituacao(Calculo calculo)
    {
        double media = calculo.CalcularMedia(Notas);
        bool aprovado = calculo.VerificarAprovacao(media);
        ExibirSituacao(media, aprovado);
    }
}