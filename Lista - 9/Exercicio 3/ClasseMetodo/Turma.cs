class Turma
{
    public string NomeTurma { get; set; }
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();

    public Turma(string nomeTurma)
    {
        NomeTurma = nomeTurma;
    }

    // Método público para adicionar aluno
    public void AdicionarAluno(Aluno aluno)
    {
        Alunos.Add(aluno);
        Console.WriteLine($"Aluno {aluno.Nome} adicionado à turma {NomeTurma}.");
    }

    // Método privado para contar aprovados
    private int ContarAprovados()
    {
        int count = 0;
        foreach (Aluno aluno in Alunos)
        {
            double soma = 0;
            foreach (double nota in aluno.Notas)
            {
                soma += nota;
            }
            double media = aluno.Notas.Count > 0 ? soma / aluno.Notas.Count : 0;
            if (media >= 7)
            {
                count++;
            }
        }
        return count;
    }

    // Método público para exibir quantidade de aprovados
    public void MostrarQuantidadeAprovados()
    {
        int aprovados = ContarAprovados();
        Console.WriteLine($"\nNa turma {NomeTurma}, {aprovados} aluno(s) foram aprovados.");
    }
}