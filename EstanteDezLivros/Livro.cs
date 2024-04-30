
public class Livro
{
    public string Titulo;
    public string Autor;
    public string Editora;
    public string Edicao;
    public int ISBN;
    public int Paginas;

    public Livro()
    {

    }
    public string DefinirTitulo()
    {
        Console.WriteLine("Qual o título do livro? ");
        return Console.ReadLine();
    }

    public string DefinirAutor()
    {
        Console.WriteLine("Qual autor ou quais autores do livro? ");
        return Console.ReadLine();
    }
    public string DefinirEditora()
    {
        Console.WriteLine("Qual a editora do livro? ");
        return Console.ReadLine();
    }
    public string DefinirEdicao()
    {
        Console.WriteLine("Qual a edição do livro? ");
        return Console.ReadLine();
    }
    public int DefinirIsbn()
    {
        Console.WriteLine("Qual o ISBN do livro? ");
        return int.Parse(Console.ReadLine());
    }
    public int DefinirPagina()
    {
        Console.WriteLine("Quantas páginas possui o livro? ");
        return int.Parse(Console.ReadLine());
    }

    public void ImprimirLivro()
    {
        Console.WriteLine($"Título: {this.Titulo}");
        Console.WriteLine($"Autor(es): {this.Autor}");
        Console.WriteLine($"Editora: {this.Editora}");
        Console.WriteLine($"Edição: {this.Edicao}");
        Console.WriteLine($"ISBN: {this.ISBN}");
        Console.WriteLine($"Páginas: {this.Paginas}");
    }

}