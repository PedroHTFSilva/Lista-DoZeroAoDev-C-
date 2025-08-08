using System.Data;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("===== CALCULADORA COM VARIÁVEIS =====");
        Console.WriteLine("Digite a expressão usando +, -, *, /, parênteses e letras (ex: a + b * (c - d)):");
        string expressao = Console.ReadLine() ?? "";

        // Verificar repetição de letras
        var letras = expressao.Where(char.IsLetter).Select(char.ToLower).ToList();

        if (letras.Count != letras.Distinct().Count())
        {
            Console.WriteLine("Erro: As letras não podem se repetir na expressão.");
            return;
        }

        Dictionary<char, double> valores = new Dictionary<char, double>();

        // Solicita valores para cada letra
        foreach (var letra in letras.Distinct())
        {
            Console.Write($"Digite o valor para '{letra}': ");
            double valor = double.Parse(Console.ReadLine() ?? "0");
            valores[letra] = valor;
        }

        // Substituir as letras pelos valores
        string expressaoSubstituida = "";
        foreach (char c in expressao)
        {
            if (char.IsLetter(c))
            {
                expressaoSubstituida += valores[char.ToLower(c)].ToString();
            }
            else
            {
                expressaoSubstituida += c;
            }
        }

        Console.WriteLine($"\nExpressão final substituída: {expressaoSubstituida}");

        try
        {
            // Usando DataTable para avaliação segura da expressão
            var resultado = new DataTable().Compute(expressaoSubstituida, null);
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao avaliar a expressão: {ex.Message}");
        }
    }
}