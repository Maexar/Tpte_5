using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }

        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Matrícula: {Matricula}";
        }
    }
}
