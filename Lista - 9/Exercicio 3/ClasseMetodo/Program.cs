class Program
{
    static void Main(string[] args)
    {
        // Criação da turma
        Console.Write("Digite o nome da turma: ");
        string nomeTurma = Console.ReadLine() ?? "Turma Padrão";
        Turma turma = new Turma(nomeTurma);

        Console.Write("Quantos alunos deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine() ?? "0");

        // Loop para cadastro de alunos
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"\nDigite o nome do aluno #{i + 1}: ");
            string nomeAluno = Console.ReadLine() ?? $"Aluno{i + 1}";
            Aluno aluno = new Aluno(nomeAluno);

            Console.Write("Quantas notas deseja adicionar para este aluno? ");
            int qtdNotas = int.Parse(Console.ReadLine() ?? "0");

            for (int j = 0; j < qtdNotas; j++)
            {
                Console.Write($"Digite a nota #{j + 1}: ");
                double nota = double.Parse(Console.ReadLine() ?? "0");
                aluno.AdicionarNota(nota);
            }

            aluno.VerificarAprovacao();
            turma.AdicionarAluno(aluno);
        }

        turma.MostrarQuantidadeAprovados();

        Console.ReadLine();
    }
}