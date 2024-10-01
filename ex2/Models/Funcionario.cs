using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Models
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Cargo: {Cargo}";
        }
    }
}
