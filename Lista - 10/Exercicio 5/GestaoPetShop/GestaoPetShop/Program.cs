class Program
{
    static void Main(string[] args)
    {
        List<Animal> animais = new List<Animal>();
        List<Produto> produtos = new List<Produto>();
        List<Veterinario> veterinarios = new List<Veterinario>();
        List<Atendimento> atendimentos = new List<Atendimento>();
        List<Venda> vendas = new List<Venda>();

        while (true)
        {
            Console.WriteLine("\n======= MENU PET SHOP =======");
            Console.WriteLine("1 - Cadastrar Animal");
            Console.WriteLine("2 - Listar Animais");
            Console.WriteLine("3 - Cadastrar Produto");
            Console.WriteLine("4 - Listar Produtos");
            Console.WriteLine("5 - Cadastrar Veterinário");
            Console.WriteLine("6 - Listar Veterinários");
            Console.WriteLine("7 - Registrar Atendimento Veterinário");
            Console.WriteLine("8 - Listar Atendimentos");
            Console.WriteLine("9 - Registrar Venda de Produto");
            Console.WriteLine("10 - Listar Vendas");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do animal: ");
                    string nomeAnimal = Console.ReadLine() ?? "Animal";

                    Console.Write("Digite a idade do animal: ");
                    int idadeAnimal = int.Parse(Console.ReadLine() ?? "0");

                    Console.Write("O animal é uma Ave ou Mamífero? (a/m): ");
                    string tipoAnimal = Console.ReadLine()?.ToLower() ?? "a";

                    if (tipoAnimal == "a")
                        animais.Add(new Ave(nomeAnimal, idadeAnimal));
                    else
                        animais.Add(new Mamifero(nomeAnimal, idadeAnimal));

                    Console.WriteLine("Animal cadastrado com sucesso!");
                    break;

                case "2":
                    Console.WriteLine("\n--- Lista de Animais ---");
                    foreach (var animal in animais)
                        animal.Listar();
                    break;

                case "3":
                    Console.Write("Digite o nome do produto: ");
                    string nomeProduto = Console.ReadLine() ?? "Produto";

                    Console.Write("Digite o preço do produto: ");
                    double precoProduto = double.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Para qual animal ou tipo de animal este produto é indicado? ");
                    string indicadoPara = Console.ReadLine() ?? "Geral";

                    produtos.Add(new Produto(nomeProduto, precoProduto, indicadoPara));
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    break;

                case "4":
                    Console.WriteLine("\n--- Lista de Produtos ---");
                    foreach (var produto in produtos)
                        produto.Listar();
                    break;

                case "5":
                    Console.Write("Digite o nome do veterinário: ");
                    string nomeVet = Console.ReadLine() ?? "Vet";

                    Console.Write("Digite o CRMV do veterinário: ");
                    string crmv = Console.ReadLine() ?? "0000";

                    veterinarios.Add(new Veterinario(nomeVet, crmv));
                    Console.WriteLine("Veterinário cadastrado com sucesso!");
                    break;

                case "6":
                    Console.WriteLine("\n--- Lista de Veterinários ---");
                    foreach (var vet in veterinarios)
                        vet.Listar();
                    break;

                case "7":
                    if (animais.Count == 0 || veterinarios.Count == 0)
                    {
                        Console.WriteLine("Necessário ter ao menos 1 animal e 1 veterinário cadastrado.");
                        break;
                    }

                    Console.WriteLine("Escolha o animal pelo número:");
                    for (int i = 0; i < animais.Count; i++)
                        Console.WriteLine($"{i} - {animais[i].Nome}");
                    int animalIndex = int.Parse(Console.ReadLine() ?? "0");
                    Animal animalSelecionado = animais[animalIndex];

                    Console.WriteLine("Escolha o veterinário pelo número:");
                    for (int i = 0; i < veterinarios.Count; i++)
                        Console.WriteLine($"{i} - {veterinarios[i].Nome}");
                    int vetIndex = int.Parse(Console.ReadLine() ?? "0");
                    Veterinario vetSelecionado = veterinarios[vetIndex];

                    atendimentos.Add(new Atendimento(animalSelecionado, vetSelecionado));
                    Console.WriteLine("Atendimento registrado com sucesso!");
                    break;

                case "8":
                    Console.WriteLine("\n--- Lista de Atendimentos ---");
                    foreach (var atendimento in atendimentos)
                        atendimento.Listar();
                    break;

                case "9":
                    if (produtos.Count == 0 || animais.Count == 0)
                    {
                        Console.WriteLine("Necessário ter ao menos 1 produto e 1 animal cadastrado.");
                        break;
                    }

                    Console.WriteLine("Escolha o produto pelo número:");
                    for (int i = 0; i < produtos.Count; i++)
                        Console.WriteLine($"{i} - {produtos[i].Nome}");
                    int prodIndex = int.Parse(Console.ReadLine() ?? "0");
                    Produto prodSelecionado = produtos[prodIndex];

                    Console.WriteLine("Escolha o animal pelo número:");
                    for (int i = 0; i < animais.Count; i++)
                        Console.WriteLine($"{i} - {animais[i].Nome}");
                    int aniIndex = int.Parse(Console.ReadLine() ?? "0");
                    Animal aniSelecionado = animais[aniIndex];

                    vendas.Add(new Venda(prodSelecionado, aniSelecionado));
                    Console.WriteLine("Venda registrada com sucesso!");
                    break;

                case "10":
                    Console.WriteLine("\n--- Lista de Vendas ---");
                    foreach (var venda in vendas)
                        venda.Listar();
                    break;

                case "0":
                    Console.WriteLine("Encerrando o sistema...");
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}