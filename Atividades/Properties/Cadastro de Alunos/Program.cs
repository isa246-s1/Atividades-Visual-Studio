using Exercicio10;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();

        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("          SISTEMA DE ALUNOS");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Pesquisar");
            Console.WriteLine("4 - Alterar");
            Console.WriteLine("5 - Excluir");
            Console.WriteLine("6 - Relatório");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("========================================");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            // CADASTRAR
            if (opcao == 1)
            {
                Aluno aluno = new Aluno();

                Console.Write("Matrícula: ");
                aluno.Matricula = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                aluno.Nome = Console.ReadLine();

                Console.Write("Idade: ");
                aluno.Idade = int.Parse(Console.ReadLine());

                Console.Write("Curso: ");
                aluno.Curso = Console.ReadLine();

                Console.Write("Nota: ");
                aluno.Nota = double.Parse(Console.ReadLine());

                alunos.Add(aluno);

                Console.WriteLine("\nAluno cadastrado com sucesso!");
            }

            // LISTAR
            else if (opcao == 2)
            {
                Console.WriteLine("\n========== ALUNOS ==========");

                if (alunos.Count == 0)
                {
                    Console.WriteLine("Nenhum aluno cadastrado.");
                }
                else
                {
                    foreach (Aluno aluno in alunos)
                    {
                        aluno.MostrarAluno();
                        Console.WriteLine("-----------------------------");
                    }
                }
            }

            // PESQUISAR
            else if (opcao == 3)
            {
                Console.Write("Digite o nome do aluno: ");
                string pesquisa = Console.ReadLine().ToLower();

                bool encontrado = false;

                foreach (Aluno aluno in alunos)
                {
                    if (aluno.Nome.ToLower().Contains(pesquisa))
                    {
                        aluno.MostrarAluno();
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }

            // ALTERAR
            else if (opcao == 4)
            {
                Console.Write("Digite a matrícula do aluno: ");
                int matricula = int.Parse(Console.ReadLine());

                Aluno alunoEncontrado = null;

                foreach (Aluno aluno in alunos)
                {
                    if (aluno.Matricula == matricula