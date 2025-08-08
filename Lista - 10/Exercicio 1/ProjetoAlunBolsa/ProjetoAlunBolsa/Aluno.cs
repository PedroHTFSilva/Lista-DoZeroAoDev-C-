using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunBolsa
{
    abstract class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<double> Notas { get; set; } = new List<double>();

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void AdicionarNota(double nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                Notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Nota inválida. Digite entre 0 e 10.");
            }
        }

        public double CalcularMedia()
        {
            double soma = 0;
            foreach (var nota in Notas)
            {
                soma += nota;
            }
            return Notas.Count > 0 ? soma / Notas.Count : 0;
        }

        public abstract void VerificarAprovacao();
    }

}
