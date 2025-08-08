class Zebra
{
    public string Nome { get; set; }

    public Zebra(string nome)
    {
        Nome = nome;
    }

    public void ComerGrama(Grama grama)
    {
        Console.WriteLine($"{Nome} está comendo a grama do tipo {grama.Tipo}.");
    }
}