using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numeros = new double[5];

        Console.WriteLine("Digite cinco números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = LerNumero($"Número {i + 1}: ");
        }

        double resultado = CalcularMultiplicacao(numeros);

        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    }

    static double LerNumero(string mensagem)
    {
        double numero;
        while (true)
        {
            Console.Write(mensagem);
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor numérico válido.");
            }
        }
    }

    static double CalcularMultiplicacao(double[] numeros)
    {
        double resultado = 1;
        foreach (double numero in numeros)
        {
            resultado *= numero;
        }
        return resultado;
    }
}
