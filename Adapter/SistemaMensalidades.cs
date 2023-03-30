using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SistemaMensalidades
    {
        public void CalculaMensalidade(List<Aluno> listaAlunos)
        {
            foreach (Aluno aluno in listaAlunos)
            { 
                Console.WriteLine($"Aluno {aluno.Nome} " +
                    $"- Valor da mensalidade R$ {aluno.Mensalidade}");
            }
        }
    }
}
