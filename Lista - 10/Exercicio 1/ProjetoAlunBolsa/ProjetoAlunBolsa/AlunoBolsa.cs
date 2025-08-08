using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunBolsa
{
    class AlunoBolsa : Aluno
    {
        public AlunoBolsa(string nome, int idade) : base(nome, idade) { }

        public override void VerificarAprovacao()
        {
            double media = CalcularMedia();
            if (media >= 6)
            {
                Console.WriteLine($"{Nome} (Aluno com Bolsa) foi aprovado com média {media:F2}.");
            }
            else
            {
                Console.WriteLine($"{Nome} (Aluno com Bolsa) foi reprovado com média {media:F2}.");
            }
        }
    }

}
