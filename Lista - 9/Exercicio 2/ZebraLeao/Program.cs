using System;

class Program
{
    static void Main(string[] args)
    {
        // Cria as instâncias com dados informados pelo usuário
        Console.Write("Digite o nome do Leão: ");
        string nomeLeao = Console.ReadLine() ?? "Leão Padrão";
        Leao leao = new Leao(nomeLeao);

        Console.Write("Digite o nome da Zebra: ");
        string nomeZebra = Console.ReadLine() ?? "Zebra Padrão";
        Zebra zebra = new Zebra(nomeZebra);

        Console.Write("Digite a cor da Grama: ");
        string corGrama = Console.ReadLine() ?? "Grama Padrão";
        Grama grama = new Grama(corGrama);

        // Interações
        leao.ComerZebra(zebra);
        zebra.ComerGrama(grama);
        grama.SerComidaPorZebra(zebra);

        Console.ReadLine();
    }
}