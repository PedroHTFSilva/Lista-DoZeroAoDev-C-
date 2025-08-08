// Funcionário herda Pessoa
class Funcionario : Pessoa
{
    public Funcionario(string nome, int idade) : base(nome, idade) { }

    public override void Listar()
    {
        Console.WriteLine($"Funcionário: {Nome}, Idade: {Idade}");
    }
}