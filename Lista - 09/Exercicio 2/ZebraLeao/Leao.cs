class Leao
{
    public string Nome { get; set; }

    public Leao(string nome)
    {
        Nome = nome;
    }

    public void ComerZebra(Zebra zebra)
    {
        Console.WriteLine($"{Nome} está tentando comer a zebra chamada {zebra.Nome}.");
    }
}