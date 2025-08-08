class Macaco
{
    public string Nome { get; set; }
    public List<Banana> BananasComidas { get; set; } = new List<Banana>();

    public Macaco(string nome)
    {
        Nome = nome;
    }

    public void ComerBanana(Banana banana)
    {
        if (banana.EstaMadura)
        {
            BananasComidas.Add(banana);
            Console.WriteLine($"{Nome} comeu uma banana {banana.Cor} madura.");
        }
        else
        {
            Console.WriteLine($"{Nome} recusou a banana {banana.Cor} porque não está madura.");
        }
    }

    public void MostrarBananasComidas()
    {
        Console.WriteLine($"\n{Nome} comeu as seguintes bananas:");
        foreach (var banana in BananasComidas)
        {
            Console.WriteLine($"- Banana {banana.Cor}");
        }
        if (BananasComidas.Count == 0)
        {
            Console.WriteLine("- Nenhuma banana comida ainda.");
        }
    }
}