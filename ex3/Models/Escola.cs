using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3.Models
{
    public class Escola
    {
        private List<Aluno> alunos;

        public Escola()
        {
            alunos = new List<Aluno>();
        }

        public void MatricularAluno(Aluno aluno)
        {
            alunos.Add(aluno);
            Console.WriteLine("Aluno matriculado com sucesso!");
        }

        public void DesmatricularAluno(string matricula)
        {
            Aluno alunoParaDesmatricular = alunos.FirstOrDefault(a => a.Matricula == matricula);
            if (alunoParaDesmatricular != null)
            {
                alunos.Remove(alunoParaDesmatricular);
                Console.WriteLine("Aluno desmatriculado com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado!");
            }
        }

        public void ListarAlunos()
        {
            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno matriculado na escola.");
            }
            else
            {
                Console.WriteLine("Alunos matriculados na escola:");
                foreach (var aluno in alunos)
                {
                    Console.WriteLine(aluno);
                }
            }
        }
    }
}
