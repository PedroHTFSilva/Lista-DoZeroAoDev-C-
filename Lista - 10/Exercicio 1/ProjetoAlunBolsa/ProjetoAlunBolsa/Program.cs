using ProjetoAlunBolsa;

class Program
{
    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"\nCadastro do aluno #{i + 1}");
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine() ?? $"Aluno{i + 1}";

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Este aluno possui bolsa? (s/n): ");
            string temBolsa = Console.ReadLine()?.ToLower() ?? "n";

            Aluno aluno;
            if (temBolsa == "s" || temBolsa == "sim")
            {
                aluno = new AlunoBolsa(nome, idade);
            }
            else
            {
                aluno = new AlunoComum(nome, idade);
            }

            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Digite a nota #{j + 1}: ");
                double nota = double.Parse(Console.ReadLine() ?? "0");
                aluno.AdicionarNota(nota);
            }

            alunos.Add(aluno);
        }

        Console.WriteLine("\nResultado Final:");
        foreach (var aluno in alunos)
        {
            aluno.VerificarAprovacao();
        }

        Console.ReadLine();
    }
}