using System;
using System.Collections.Generic;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>();

            int opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("       CADASTRO DE LIVROS");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Cadastrar livro");
                Console.WriteLine("2 - Listar livros");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Livro livro = new Livro();

                    Console.Write("Título: ");
                    livro.Titulo = Console.ReadLine();

                    Console.Write("Autor: ");
                    livro.Autor = Console.ReadLine();

                    Console.Write("Ano: ");
                    livro.Ano = int.Parse(Console.ReadLine());

                    Console.Write("Categoria: ");
                    livro.Categoria = Console.ReadLine();

                    Console.Write("O livro está disponível? (s/n): ");
                    string resposta = Console.ReadLine();

                    livro.Disponivel = resposta.ToLower() == "s";

                    livros.Add(livro);

                    Console.WriteLine("\nLivro cadastrado com sucesso!");
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\n===== LIVROS CADASTRADOS =====");

                    if (livros.Count == 0)
                    {
                        Console.WriteLine("Nenhum livro cadastrado.");
                    }
                    else
                    {
                        foreach (Livro livro in livros)
                        {
                            livro.MostrarLivro();
                            Console.WriteLine("--------------------------------");
                        }
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
