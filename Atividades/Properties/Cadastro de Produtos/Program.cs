using System;
using System.Collections.Generic;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            int opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("     CADASTRO DE PRODUTOS");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Produto produto = new Produto();

                    Console.Write("Nome: ");
                    produto.Nome = Console.ReadLine();

                    Console.Write("Categoria: ");
                    produto.Categoria = Console.ReadLine();

                    Console.Write("Preço: ");
                    produto.Preco = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade: ");
                    produto.Quantidade = int.Parse(Console.ReadLine());

                    produtos.Add(produto);

                    Console.WriteLine("\nProduto cadastrado com sucesso!");
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\n===== PRODUTOS CADASTRADOS =====");

                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    else
                    {
                        foreach (Produto produto in produtos)
                        {
                            produto.MostrarProduto();
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
