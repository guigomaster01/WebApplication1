using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AlunoModel2
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public DateTime Matricula { get; set; }
        public int Faltas { get; set; }

        public AlunoModel2()
        {
            Nome = "Rodrigo";
            Curso = "Desenvolvimento de Sistemas";
            Faltas = 1;
            Matricula = new DateTime(2023,1,27);
        }

        public static AlunoModel2 CriarEmerson()
        {
            var aluno = new AlunoModel2();
            aluno.Nome = "Emerson";
            return aluno;

        }
    }
}
