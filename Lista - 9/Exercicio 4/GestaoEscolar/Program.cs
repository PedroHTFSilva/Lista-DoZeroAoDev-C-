class Program
{
    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();
        Calculo calculo = new Calculo();

        Console.Write("Quantos alunos deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"\nDigite o nome do aluno #{i + 1}: ");
            string nomeAluno = Console.ReadLine() ?? $"Aluno{i + 1}";
            Aluno aluno = new Aluno(nomeAluno);

            Console.Write($"Quantas notas deseja adicionar para {nomeAluno}? ");
            int qtdNotas = int.Parse(Console.ReadLine() ?? "0");

            for (int j = 0; j < qtdNotas; j++)
            {
                Console.Write($"Digite a nota #{j + 1}: ");
                double nota = double.Parse(Console.ReadLine() ?? "0");
                aluno.AdicionarNota(nota);
            }

            aluno.CalcularSituacao(calculo);
            alunos.Add(aluno);
        }

        Console.WriteLine("\nTodos os alunos foram processados!");
        Console.ReadLine();
    }
}