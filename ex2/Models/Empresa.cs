using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Models
{
    public class Empresa
    {
        private List<Funcionario> funcionarios;

        public Empresa()
        {
            funcionarios = new List<Funcionario>();
        }

        public void ContratarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
            Console.WriteLine("Funcionário contratado com sucesso!");
        }

        public void DemitirFuncionario(string nome)
        {
            Funcionario funcionarioParaDemitir = funcionarios.FirstOrDefault(f => f.Nome == nome);
            if (funcionarioParaDemitir != null)
            {
                funcionarios.Remove(funcionarioParaDemitir);
                Console.WriteLine("Funcionário demitido com sucesso!");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado!");
            }
        }

        public void ListarFuncionarios()
        {
            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário na empresa.");
            }
            else
            {
                Console.WriteLine("Funcionários da empresa:");
                foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine(funcionario);
                }
            }
        }
    }
}
