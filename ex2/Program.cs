using ex2.Models;

class Program
{
    static void Main(string[] args)
    {
        Empresa empresa = new Empresa();

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Contratar Funcionário");
            Console.WriteLine("2. Demitir Funcionário");
            Console.WriteLine("3. Listar Funcionários");
            Console.WriteLine("4. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do funcionário: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o cargo do funcionário: ");
                    string cargo = Console.ReadLine();
                    Funcionario novoFuncionario = new Funcionario(nome, cargo);
                    empresa.ContratarFuncionario(novoFuncionario);
                    break;

                case "2":
                    Console.Write("Digite o nome do funcionário a ser demitido: ");
                    string nomeParaDemitir = Console.ReadLine();
                    empresa.DemitirFuncionario(nomeParaDemitir);
                    break;

                case "3":
                    empresa.ListarFuncionarios();
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