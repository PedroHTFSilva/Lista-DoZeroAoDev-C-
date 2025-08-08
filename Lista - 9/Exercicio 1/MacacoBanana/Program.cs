using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o nome do macaco:");
        string nomeMacaco = Console.ReadLine();
        Macaco macaco = new Macaco(nomeMacaco);

        Console.WriteLine("Quantas bananas deseja cadastrar?");
        int quantidade = int.Parse(Console.ReadLine());

        List<Banana> bananas = new List<Banana>();

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\nBanana #{i + 1}:");

            Console.Write("Informe a cor da banana: ");
            string cor = Console.ReadLine();

            Console.Write("A banana está madura? (s/n): ");
            string resposta = Console.ReadLine().ToLower();
            bool estaMadura = resposta == "s" || resposta == "sim";

            Banana banana = new Banana(cor, estaMadura);
            bananas.Add(banana);
        }

        // Loop para o macaco tentar comer todas as bananas cadastradas
        foreach (var banana in bananas)
        {
            macaco.ComerBanana(banana);
        }

        // Mostrar as bananas comidas no final
        macaco.MostrarBananasComidas();

        Console.ReadLine();
    }
}