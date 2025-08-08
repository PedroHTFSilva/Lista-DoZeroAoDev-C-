class Calculadora : CalculadoraBase
{
    // Método de Soma
    public double Somar(double a, double b)
    {
        return a + b;
    }

    // Método de Subtração
    public double Subtrair(double a, double b)
    {
        return a - b;
    }

    // Método de Multiplicação
    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    // Método de Divisão
    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: divisão por zero!");
            return 0;
        }
        return a / b;
    }
}