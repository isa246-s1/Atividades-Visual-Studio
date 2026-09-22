using System;
using System.Collections.Generic;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Filme> filmes = new List<Filme>();

            int opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("       CADASTRO DE FILMES");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Cadastrar filme");
                Console.WriteLine("2 - Listar filmes");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Filme filme = new Filme();

                    Console.Write("Título: ");
                    filme.Titulo = Console.ReadLine();

                    Console.Write("Gênero: ");
                    filme.Genero = Console.ReadLine();

                    Console.Write("Ano: ");
                    filme.Ano = int.Parse(Console.ReadLine());

                    Console.Write("Duração em minutos: ");
                    filme.Duracao = int.Parse(Console.ReadLine());

                    Console.Write("Nota: ");
                    filme.Nota = double.Parse(Console.ReadLine());

                    filmes.Add(filme);

                    Console.WriteLine("\nFilme cadastrado!");
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    foreach (Filme filme in filmes)
                    {
                        filme.ExibirInformacoes();
                        Console.WriteLine("--------------------------------");
                    }

                    Console.ReadKey();
                }

            } while (opcao != 3);
        }
    }
}
