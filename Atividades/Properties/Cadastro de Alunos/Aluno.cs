namespace Exercicio10;

public class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Curso { get; set; }
    public double Nota { get; set; }

    public void MostrarAluno()
    {
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Nota: {Nota:F1}");

        if (Nota >= 7)
        {
            Console.WriteLine("Situação: APROVADO");
        }
        else
        {
            Console.WriteLine("Situação: REPROVADO");
        }
    }

    public string