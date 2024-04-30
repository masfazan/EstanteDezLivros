int cadastro = 0;
char resposta;
Livro livro = new Livro();
Livro[] livros = new Livro[10];


Livro InserirLivro()
{
    Livro livroInserido = new Livro();

    livroInserido.Titulo = livroInserido.DefinirTitulo();
    livroInserido.Autor = livroInserido.DefinirAutor();
    livroInserido.Editora = livroInserido.DefinirEditora();
    livroInserido.Edicao = livroInserido.DefinirEdicao();
    livroInserido.ISBN = livroInserido.DefinirIsbn();
    livroInserido.Paginas = livroInserido.DefinirPagina();

    return livroInserido;
}

do
{
    Console.WriteLine($"Cadastre o Livro {cadastro + 1}");
    livros[cadastro] = InserirLivro();
    Console.WriteLine();
    cadastro++;
    if (cadastro >= 2)
    {
        Console.WriteLine("Estante cheia!");
        break;
    }
    else
    {
        Console.WriteLine("Gostaria de incluir mais um?\nDigite: S-para sim e N-para não");
        resposta = char.Parse(Console.ReadLine());
    }
    if (resposta == 'n') ;
    break;

} while (resposta == 's');

Console.ReadLine();

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Livro {i + 1}:");
    livros[i].ImprimirLivro();//metodo não instanciado
}
Console.ReadLine();






/*for (int i = 0; i < 1; i++)
{
   
    Console.WriteLine($"Cadastre o Livro {i+1}");
    livros[i] = InserirLivro();
    Console.WriteLine();
}
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Livro {i + 1}:");
    livros[i].ImprimirLivro();
}*/