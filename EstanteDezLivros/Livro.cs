
using System.ComponentModel.Design;

public class Livro
{
    public string Titulo;
    public string []Autor;
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

    public string[] DefinirAutor()
    {
        int autor = 0;
        string[] autores = new string[3];
        do
        {
            Console.WriteLine("Digite a quantidade de autores (mínimo 1 e máximo 3): ");
            autor = int.Parse(Console.ReadLine());
            if (autor == 0 || autor > 3)
            {
                Console.WriteLine("O cadastro só pode ser realizado com no mínimo 1 autor e no máximo 3 ");
            }
            else
            {
                break;//se não for essa opção ele quebra o laço, para não gerar essa mensagem em opções válidas
            }
        }while(autor == 0 || autor >3);
        for (int i = 0; i < autor; i++)
        {
            Console.WriteLine($"Digite o nome do autor {i + 1}:  ");
            autores[i] = Console.ReadLine();
        }
        return autores;
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
        Console.WriteLine("Autor(es): ");
        for (int i = 0; i<this.Autor.Length; i++) 
        {
            Console.WriteLine(this.Autor[i]+"\n");
        }
        Console.WriteLine($"Editora: {this.Editora}");
        Console.WriteLine($"Edição: {this.Edicao}");
        Console.WriteLine($"ISBN: {this.ISBN}");
        Console.WriteLine($"Páginas: {this.Paginas}");
    }

}