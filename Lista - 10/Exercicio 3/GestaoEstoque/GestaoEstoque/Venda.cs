// Venda
class Venda : IListavel
{
    public Pessoa Cliente { get; set; }
    public Produto Produto { get; set; }
    public int QuantidadeVendida { get; set; }
    public double Total => Produto.Preco * QuantidadeVendida;

    public Venda(Pessoa cliente, Produto produto, int quantidadeVendida)
    {
        Cliente = cliente;
        Produto = produto;
        QuantidadeVendida = quantidadeVendida;
        Produto.Quantidade -= quantidadeVendida;
    }

    public void Listar()
    {
        Console.WriteLine($"Venda - Cliente: {Cliente.Nome}, Produto: {Produto.Nome}, Quantidade: {QuantidadeVendida}, Total: R${Total:F2}");
    }
}