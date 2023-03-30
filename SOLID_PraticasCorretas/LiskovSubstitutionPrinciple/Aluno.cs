using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PraticasCorretas.LiskovSubstitutionPrinciple
{
    internal class Aluno: Pessoa
    {
        public int Nota { get; set; }
        public string Turma { get; set; }
        public int AnoLetivo { get; set; }
       
        public Disciplina Disciplina { get; set; }

    }
}
