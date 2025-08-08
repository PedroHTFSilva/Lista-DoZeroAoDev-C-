// Classe Aluguel
class Aluguel : IListavel
{
    public Cliente Cliente { get; set; }
    public Filme Filme { get; set; }
    public DateTime DataAluguel { get; set; }
    public double ValorCobrado { get; set; }

    public Aluguel(Cliente cliente, Filme filme)
    {
        Cliente = cliente;
        Filme = filme;
        DataAluguel = DateTime.Now;

        double preco = filme.Preco;
        if (cliente.IsPremium())
        {
            preco *= 0.9; // 10% de desconto
        }
        ValorCobrado = preco;

        filme.Disponivel = false;
        cliente.FilmesAlugadosHistorico++;
    }

    public void Listar()
    {
        Console.WriteLine($"Aluguel - Cliente: {Cliente.Nome}, Filme: {Filme.Titulo}, Data: {DataAluguel}, Valor Cobrado: R${ValorCobrado:F2}");
    }
}