// Classe Devolução
class Devolucao : IListavel
{
    public Cliente Cliente { get; set; }
    public Filme Filme { get; set; }
    public DateTime DataDevolucao { get; set; }

    public Devolucao(Cliente cliente, Filme filme)
    {
        Cliente = cliente;
        Filme = filme;
        DataDevolucao = DateTime.Now;
        filme.Disponivel = true;
    }

    public void Listar()
    {
        Console.WriteLine($"Devolução - Cliente: {Cliente.Nome}, Filme: {Filme.Titulo}, Data: {DataDevolucao}");
    }
}