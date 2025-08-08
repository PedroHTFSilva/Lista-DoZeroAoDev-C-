class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        List<Produto> produtos = new List<Produto>();
        List<Venda> vendas = new List<Venda>();

        // Cadastro de Produtos
        Console.WriteLine("Cadastro de produtos:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nProduto #{i + 1}");
            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine() ?? $"Produto{i + 1}";

            Console.Write("Digite o preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a quantidade do produto: ");
            int quantidadeProduto = int.Parse(Console.ReadLine() ?? "0");

            produtos.Add(new Produto(nomeProduto, precoProduto, quantidadeProduto));
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        Console.WriteLine("\n--- Produtos Cadastrados ---");
        foreach (var produto in produtos)
        {
            produto.Listar();
        }

        // Cadastro de Pessoas
        Console.WriteLine("\nCadastro de 2 pessoas (Cliente e Funcionário)\n");

        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Digite o nome da pessoa #{i + 1}: ");
            string nome = Console.ReadLine() ?? $"Pessoa{i + 1}";

            Console.Write($"Digite a idade de {nome}: ");
            int idade = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Essa pessoa é Cliente ou Funcionário? (c/f): ");
            string tipo = Console.ReadLine()?.ToLower() ?? "c";

            if (tipo == "c")
                pessoas.Add(new Cliente(nome, idade));
            else
                pessoas.Add(new Funcionario(nome, idade));
        }

        Console.WriteLine("\n--- Pessoas Cadastradas ---");
        foreach (var pessoa in pessoas)
        {
            pessoa.Listar();
        }

        // Cadastro de Vendas
        Console.WriteLine("\nCadastro de vendas");

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\nVenda #{i + 1}");
            Console.WriteLine("Escolha o cliente pelo número:");

            for (int j = 0; j < pessoas.Count; j++)
            {
                Console.WriteLine($"{j} - {pessoas[j].Nome}");
            }
            int clienteIndex = int.Parse(Console.ReadLine() ?? "0");
            Pessoa cliente = pessoas[clienteIndex];

            Console.WriteLine("Escolha o produto pelo número:");
            for (int k = 0; k < produtos.Count; k++)
            {
                Console.WriteLine($"{k} - {produtos[k].Nome} (Estoque: {produtos[k].Quantidade})");
            }
            int produtoIndex = int.Parse(Console.ReadLine() ?? "0");
            Produto produtoSelecionado = produtos[produtoIndex];

            Console.Write("Digite a quantidade a ser vendida: ");
            int quantidadeVendida = int.Parse(Console.ReadLine() ?? "0");

            if (quantidadeVendida <= produtoSelecionado.Quantidade)
            {
                vendas.Add(new Venda(cliente, produtoSelecionado, quantidadeVendida));
                Console.WriteLine("Venda realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
        }

        Console.WriteLine("\n--- Vendas Realizadas ---");
        foreach (var venda in vendas)
        {
            venda.Listar();
        }

        Console.WriteLine("\n--- Estoque Atualizado ---");
        foreach (var produto in produtos)
        {
            produto.Listar();
        }

        Console.ReadLine();
    }
}