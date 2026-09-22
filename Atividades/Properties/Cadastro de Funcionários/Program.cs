using System;
using System.Collections.Generic;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            int opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("    CADASTRO DE FUNCIONÁRIOS");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Cadastrar funcionário");
                Console.WriteLine("2 - Listar funcionários");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Funcionario funcionario = new Funcionario();

                    Console.Write("Nome: ");
                    funcionario.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    funcionario.Idade = int.Parse(Console.ReadLine());

                    Console.Write("Cargo: ");
                    funcionario.Cargo = Console.ReadLine();

                    Console.Write("Salário: ");
                    funcionario.Salario = double.Parse(Console.ReadLine());

                    Console.Write("Setor: ");
                    funcionario.Setor = Console.ReadLine();

                    funcionarios.Add(funcionario);

                    Console.WriteLine("\nFuncionário cadastrado!");
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\n===== FUNCIONÁRIOS =====");

                    foreach (Funcionario funcionario in funcionarios)
                    {
                        funcionario.Apresentar();

                        Console.WriteLine("Salário anual: R$ " +
                            funcionario.CalcularSalarioAnual().ToString("F2"));

                        Console.WriteLine("--------------------------------");
                    }

                    Console.ReadKey();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Programa encerrado.");
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                }

            } while (opcao != 3);
        }
    }
}
