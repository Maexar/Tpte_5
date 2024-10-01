using ex3.Models;

class Program
{
    static void Main(string[] args)
    {
        Escola escola = new Escola();

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Matricular Aluno");
            Console.WriteLine("2. Desmatricular Aluno");
            Console.WriteLine("3. Listar Alunos");
            Console.WriteLine("4. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do aluno: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite a matrícula do aluno: ");
                    string matricula = Console.ReadLine();
                    Aluno novoAluno = new Aluno(nome, matricula);
                    escola.MatricularAluno(novoAluno);
                    break;

                case "2":
                    Console.Write("Digite a matrícula do aluno a ser desmatriculado: ");
                    string matriculaParaDesmatricular = Console.ReadLine();
                    escola.DesmatricularAluno(matriculaParaDesmatricular);
                    break;

                case "3":
                    escola.ListarAlunos();
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