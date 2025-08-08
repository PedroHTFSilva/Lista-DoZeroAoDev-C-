// Classe Filme
class Filme : IListavel
{
    public string Titulo { get; set; }
    public double Preco { get; set; }
    public bool Disponivel { get; set; } = true;

    public Filme(string titulo, double preco)
    {
        Titulo = titulo;
        Preco = preco;
    }

    public void Listar()
    {
        Console.WriteLine($"Filme: {Titulo}, Preço: R${Preco:F2}, Disponível: {Disponivel}");
    }
}