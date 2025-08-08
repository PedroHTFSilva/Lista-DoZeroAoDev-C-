using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a temperatura em Celsius:");
        double temperaturaCelsius = LerTemperatura();

        double temperaturaFahrenheit = ConverterParaFahrenheit(temperaturaCelsius);

        Console.WriteLine($"A temperatura em Fahrenheit é: {temperaturaFahrenheit} °F");
    }

    public static double LerTemperatura()
    {
        double temperatura;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out temperatura))
            {
                return temperatura;
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor numérico válido para a temperatura.");
            }
        }
    }

    public static double ConverterParaFahrenheit(double temperaturaCelsius)
    {
        return (temperaturaCelsius * 9 / 5) + 32;
    }
}
