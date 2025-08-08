// Venda de Produto
class Venda : IListavel
{
    public Produto ProdutoVendido { get; set; }
    public Animal AnimalRelacionado { get; set; }
    public DateTime Data { get; set; }
    public double Valor { get; set; }

    public Venda(Produto produto, Animal animal)
    {
        ProdutoVendido = produto;
        AnimalRelacionado = animal;
        Data = DateTime.Now;
        Valor = produto.Preco;
    }

    public void Listar()
    {
        Console.WriteLine($"Venda - Produto: {ProdutoVendido.Nome}, Animal: {AnimalRelacionado.Nome}, Valor: R${Valor:F2}, Data: {Data}");
    }
}