class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        calc.MostrarCabecalho();

        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine() ?? "0");

        double resultado = 0;

        switch (opcao)
        {
            case 1:
                resultado = calc.Somar(num1, num2);
                Console.WriteLine($"Resultado da soma: {resultado}");
                break;
            case 2:
                resultado = calc.Subtrair(num1, num2);
                Console.WriteLine($"Resultado da subtração: {resultado}");
                break;
            case 3:
                resultado = calc.Multiplicar(num1, num2);
                Console.WriteLine($"Resultado da multiplicação: {resultado}");
                break;
            case 4:
                resultado = calc.Dividir(num1, num2);
                Console.WriteLine($"Resultado da divisão: {resultado}");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        Console.ReadLine();
    }
}