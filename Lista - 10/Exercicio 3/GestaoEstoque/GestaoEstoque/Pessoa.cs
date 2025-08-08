// Classe base Pessoa
abstract class Pessoa : IListavel
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public abstract void Listar();
}