using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Models
{
    public class Biblioteca
    {
        private List<Livro> livros;

        public Biblioteca()
        {
            livros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
            Console.WriteLine("Livro adicionado com sucesso!");
        }

        public void RemoverLivro(string titulo)
        {
            Livro livroParaRemover = livros.FirstOrDefault(l => l.Titulo == titulo);
            if (livroParaRemover != null)
            {
                livros.Remove(livroParaRemover);
                Console.WriteLine("Livro removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Livro não encontrado!");
            }
        }

        public void ListarLivros()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("A biblioteca está vazia.");
            }
            else
            {
                Console.WriteLine("Livros na biblioteca:");
                foreach (var livro in livros)
                {
                    Console.WriteLine(livro);
                }
            }
        }
    }
}
