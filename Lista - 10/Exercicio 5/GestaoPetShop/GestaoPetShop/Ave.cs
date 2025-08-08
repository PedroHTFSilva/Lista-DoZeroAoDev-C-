// Ave herda Animal
class Ave : Animal
{
    public Ave(string nome, int idade) : base(nome, idade) { }

    public override void Listar()
    {
        Console.WriteLine($"Ave: {Nome}, Idade: {Idade}");
    }
}