using ex1.Models;

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Remover Livro");
            Console.WriteLine("3. Listar Livros");
            Console.WriteLine("4. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o título do livro: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Digite o autor do livro: ");
                    string autor = Console.ReadLine();
                    Livro novoLivro = new Livro(titulo, autor);
                    biblioteca.AdicionarLivro(novoLivro);
                    break;

                case "2":
                    Console.Write("Digite o título do livro a ser removido: ");
                    string tituloParaRemover = Console.ReadLine();
                    biblioteca.RemoverLivro(tituloParaRemover);
                    break;

                case "3":
                    biblioteca.ListarLivros();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
