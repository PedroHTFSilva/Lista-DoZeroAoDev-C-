// Atendimento Veterinário
class Atendimento : IListavel
{
    public Animal AnimalAtendido { get; set; }
    public Veterinario VeterinarioResponsavel { get; set; }
    public DateTime Data { get; set; }

    public Atendimento(Animal animal, Veterinario vet)
    {
        AnimalAtendido = animal;
        VeterinarioResponsavel = vet;
        Data = DateTime.Now;
    }

    public void Listar()
    {
        Console.WriteLine($"Atendimento - Animal: {AnimalAtendido.Nome}, Veterinário: {VeterinarioResponsavel.Nome}, Data: {Data}");
    }
}