int[] livros = int[10];
Livro livro = new Livro();


Livro InserirLivro()
{
    Livro livroInserido= new Livro();

    livroInserido.Titulo = livroInserido.DefinirTitulo();
    livroInserido.Autor = livroInserido.DefinirAutor();
    livroInserido.Editora= livroInserido.DefinirEditora();
    livroInserido.Edicao= livroInserido.DefinirEdicao();
    livroInserido.ISBN = livroInserido.DefinirIsbn();
    livroInserido.Paginas= livroInserido.DefinirPagina();

    return livroInserido;
}

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Cadastre o {livros[i]}");
    livro =InserirLivro();
    //Console.ReadLine(livros[i]);
}
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Livro{livros[i]}");
}


