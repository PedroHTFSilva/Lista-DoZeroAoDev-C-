// Produto
class Produto : IListavel
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string IndicadoPara { get; set; }

    public Produto(string nome, double preco, string indicadoPara)
    {
        Nome = nome;
        Preco = preco;
        IndicadoPara = indicadoPara;
    }

    public void Listar()
    {
        Console.WriteLine($"Produto: {Nome}, Preço: R${Preco:F2}, Indicado para: {IndicadoPara}");
    }
}