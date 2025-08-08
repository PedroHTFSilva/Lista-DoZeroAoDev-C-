class Program
{
    static void Main(string[] args)
    {
        List<Filme> filmes = new List<Filme>();
        List<Cliente> clientes = new List<Cliente>();
        List<Aluguel> alugueis = new List<Aluguel>();
        List<Devolucao> devolucoes = new List<Devolucao>();

        while (true)
        {
            Console.WriteLine("\n======= MENU LOCADORA =======");
            Console.WriteLine("1 - Cadastrar Filme");
            Console.WriteLine("2 - Listar Filmes");
            Console.WriteLine("3 - Cadastrar Cliente");
            Console.WriteLine("4 - Listar Clientes");
            Console.WriteLine("5 - Realizar Aluguel");
            Console.WriteLine("6 - Listar Aluguéis");
            Console.WriteLine("7 - Realizar Devolução");
            Console.WriteLine("8 - Listar Devoluções");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o título do filme: ");
                    string titulo = Console.ReadLine() ?? "Sem Título";

                    Console.Write("Digite o preço do filme: ");
                    double preco = double.Parse(Console.ReadLine() ?? "0");

                    filmes.Add(new Filme(titulo, preco));
                    Console.WriteLine("Filme cadastrado com sucesso!");
                    break;

                case "2":
                    Console.WriteLine("\n--- Lista de Filmes ---");
                    foreach (var filme in filmes)
                        filme.Listar();
                    break;

                case "3":
                    Console.Write("Digite o nome do cliente: ");
                    string nomeCliente = Console.ReadLine() ?? "Cliente";

                    clientes.Add(new Cliente(nomeCliente));
                    Console.WriteLine("Cliente cadastrado com sucesso!");
                    break;

                case "4":
                    Console.WriteLine("\n--- Lista de Clientes ---");
                    foreach (var cliente in clientes)
                        cliente.Listar();
                    break;

                case "5":
                    if (clientes.Count == 0 || filmes.Count == 0)
                    {
                        Console.WriteLine("Necessário ter ao menos 1 cliente e 1 filme cadastrado.");
                        break;
                    }

                    Console.WriteLine("Escolha o cliente pelo número:");
                    for (int i = 0; i < clientes.Count; i++)
                        Console.WriteLine($"{i} - {clientes[i].Nome}");
                    int clienteIndex = int.Parse(Console.ReadLine() ?? "0");
                    Cliente clienteSelecionado = clientes[clienteIndex];

                    Console.WriteLine("Escolha o filme pelo número:");
                    for (int i = 0; i < filmes.Count; i++)
                        Console.WriteLine($"{i} - {filmes[i].Titulo} (Disponível: {filmes[i].Disponivel})");
                    int filmeIndex = int.Parse(Console.ReadLine() ?? "0");
                    Filme filmeSelecionado = filmes[filmeIndex];

                    if (filmeSelecionado.Disponivel)
                    {
                        alugueis.Add(new Aluguel(clienteSelecionado, filmeSelecionado));
                        Console.WriteLine("Aluguel realizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Filme indisponível no momento.");
                    }
                    break;

                case "6":
                    Console.WriteLine("\n--- Lista de Aluguéis ---");
                    foreach (var aluguel in alugueis)
                        aluguel.Listar();
                    break;

                case "7":
                    if (alugueis.Count == 0)
                    {
                        Console.WriteLine("Não há aluguéis para devolução.");
                        break;
                    }

                    Console.WriteLine("Escolha o aluguel para devolução pelo número:");
                    for (int i = 0; i < alugueis.Count; i++)
                        Console.WriteLine($"{i} - Cliente: {alugueis[i].Cliente.Nome}, Filme: {alugueis[i].Filme.Titulo}");
                    int devolucaoIndex = int.Parse(Console.ReadLine() ?? "0");

                    Aluguel aluguelSelecionado = alugueis[devolucaoIndex];
                    devolucoes.Add(new Devolucao(aluguelSelecionado.Cliente, aluguelSelecionado.Filme));
                    alugueis.RemoveAt(devolucaoIndex);
                    Console.WriteLine("Devolução realizada com sucesso!");
                    break;

                case "8":
                    Console.WriteLine("\n--- Lista de Devoluções ---");
                    foreach (var devolucao in devolucoes)
                        devolucao.Listar();
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