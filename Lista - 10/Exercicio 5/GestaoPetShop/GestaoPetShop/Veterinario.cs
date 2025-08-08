// Médico Veterinário
class Veterinario : IListavel
{
    public string Nome { get; set; }
    public string Codigo { get; set; }

    public Veterinario(string nome, string crmv)
    {
        Nome = nome;
        Codigo = crmv;
    }

    public void Listar()
    {
        Console.WriteLine($"Veterinário: {Nome}, CRMV: {Codigo}");
    }
}