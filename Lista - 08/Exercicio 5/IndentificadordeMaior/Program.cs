using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {

        int quantidadeNumeros = 4;
        int maior = int.MinValue;

        Console.WriteLine("Digite 4 numeros para indentificar o maior");


        for (int i = 1; i <= quantidadeNumeros; i++)
        {
            Console.Write($"Numero{i}: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"O maior número digitado é: {maior}");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}