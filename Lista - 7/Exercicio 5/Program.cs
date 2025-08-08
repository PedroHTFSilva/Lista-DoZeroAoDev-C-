using System;

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Digite sua idade:");
        int idade = LerInteiro();

        Console.WriteLine("Digite seu gênero (M para masculino, F para feminino):");
        char genero = LerGenero();

        Console.WriteLine("Digite seu peso (em kg):");
        double peso = LerDouble();

        Console.WriteLine("Digite sua altura (em metros):");
        double altura = LerDouble();

        Console.WriteLine("\nInformações fornecidas:");
        Console.WriteLine($"Idade: {idade} anos");
        Console.WriteLine($"Gênero: {(genero == 'M' ? "Masculino" : "Feminino")}");
        Console.WriteLine($"Peso: {peso} kg");
        Console.WriteLine($"Altura: {altura} metros");
    }

    static int LerInteiro()
    {
        int valor;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out valor))
            {
                return valor;
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor inteiro válido.");
            }
        }
    }


    static char LerGenero()
    {
        char genero;
        while (true)
        {   //LÓGICA PARA CONTROLE E BOA PRÁTICA DE PROGRAMAÇÃO M OR F
            if (char.TryParse(Console.ReadLine(), out genero) && (genero == 'M' || genero == 'F'))
            {
                return genero;
            }
            else
            {
                Console.WriteLine("Por favor, insira 'M' para masculino ou 'F' para feminino.");
            }
        }
    }

    static double LerDouble()
    {
        double valor;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out valor))
            {
                return valor;
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor numérico válido.");
            }
        }
    }
}
