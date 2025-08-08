// Produto
class Produto : IListavel
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public void Listar()
    {
        Console.WriteLine($"Produto: {Nome}, Preço: R${Preco:F2}, Quantidade: {Quantidade}");
    }
}