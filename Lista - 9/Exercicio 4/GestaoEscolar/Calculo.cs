class Calculo
{
    // Método público para calcular média de uma lista de notas
    public double CalcularMedia(List<double> notas)
    {
        return SomarNotas(notas) / (notas.Count > 0 ? notas.Count : 1);
    }

    // Método privado para somar as notas
    private double SomarNotas(List<double> notas)
    {
        double soma = 0;
        foreach (double nota in notas)
        {
            soma += nota;
        }
        return soma;
    }

    // Método público para verificar aprovação
    public bool VerificarAprovacao(double media)
    {
        return media >= 7;
    }
}