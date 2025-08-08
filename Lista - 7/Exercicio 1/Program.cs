using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Bem vindo ao Software de subtração!");
        
        Console.WriteLine("Digite o primeiro número inteiro:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número inteiro:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultado = Subtrair(num1, num2);

        Console.WriteLine($"O resultado da subtração de {num1} e {num2} é: {resultado}");
    }

    static int Subtrair(int a, int b)
    {
        return a - b;
    }
}
