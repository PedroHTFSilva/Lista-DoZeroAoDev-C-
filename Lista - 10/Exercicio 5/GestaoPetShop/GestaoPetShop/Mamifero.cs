// Mamífero herda Animal
class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { }

    public override void Listar()
    {
        Console.WriteLine($"Mamífero: {Nome}, Idade: {Idade}");
    }
}