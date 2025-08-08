// Cliente herda Pessoa
class Cliente : Pessoa
{
    public Cliente(string nome, int idade) : base(nome, idade) { }

    public override void Listar()
    {
        Console.WriteLine($"Cliente: {Nome}, Idade: {Idade}");
    }
}