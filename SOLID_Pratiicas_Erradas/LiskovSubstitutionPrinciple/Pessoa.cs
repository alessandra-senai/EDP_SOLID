using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Pratiicas_Erradas.LiskovSubstitutionPrinciple
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public string CPF { get; set; }
        public int Nota { get; set; }
        public string Turma { get; set; }
        public int AnoLetivo { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}
