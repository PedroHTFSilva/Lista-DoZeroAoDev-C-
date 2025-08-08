using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunBolsa
{
    class AlunoComum : Aluno
    {
        public AlunoComum(string nome, int idade) : base(nome, idade) { }

        public override void VerificarAprovacao()
        {
            double media = CalcularMedia();
            if (media >= 7)
            {
                Console.WriteLine($"{Nome} (Aluno Comum) foi aprovado com média {media:F2}.");
            }
            else
            {
                Console.WriteLine($"{Nome} (Aluno Comum) foi reprovado com média {media:F2}.");
            }
        }
    }
}
