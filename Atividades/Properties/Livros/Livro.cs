namespace Exercicio02
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string Categoria { get; set; }
        public bool Disponivel { get; set; }

        public void MostrarLivro()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Categoria: " + Categoria);

            if (Disponivel)
            {
                Console.WriteLine("Situação: DISPONÍVEL");
            }
            else
            {
                Console.WriteLine("Situação: EMPRESTADO");
            }
        }
    }
}
