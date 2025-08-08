class Grama
{
    public string Tipo { get; set; }

    public Grama(string tipo)
    {
        Tipo = tipo;
    }

    public void SerComidaPorZebra(Zebra zebra)
    {
        Console.WriteLine($"A grama {Tipo} está sendo comida pela zebra chamada {zebra.Nome}.");
    }
}