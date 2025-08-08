// Classe Cliente
class Cliente : IListavel
{
    public string Nome { get; set; }
    public int FilmesAlugadosHistorico { get; set; }

    public Cliente(string nome)
    {
        Nome = nome;
        FilmesAlugadosHistorico = 0;
    }

    public bool IsPremium()
    {
        return FilmesAlugadosHistorico > 10;
    }

    public void Listar()
    {
        string tipo = IsPremium() ? "Premium (10% de desconto)" : "Comum";
        Console.WriteLine($"Cliente: {Nome}, Tipo: {tipo}, Total de Filmes Alugados: {FilmesAlugadosHistorico}");
    }
}