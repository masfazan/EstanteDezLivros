int cadastro = 0;
char resposta;
Livro livro = new Livro();
Livro[] livros = new Livro[10];

int Menu()
{
    Console.WriteLine("1-Cadastrar livro");
    Console.WriteLine("2-Imprimir estante");
    Console.WriteLine("3-Imprimir livro específico");
    Console.WriteLine("4-Sair do cadastro");
    Console.WriteLine("Escolha sua opção: ");
    return int.Parse(Console.ReadLine());
}

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
void AdicionarLivroEstante()
{
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
}
void ImprimirEstante()
{
    for (int i = 0; i < cadastro; i++)
{
        Console.WriteLine($"Livro {i + 1}:");
        livros[i].ImprimirLivro();
    }
}
void BuscarLivro(int i)
{
    livros[i].ImprimirLivro();
}

do
{
    switch (Menu() )
    {
        case 1:
            AdicionarLivroEstante();
            break;
        case 2:
            ImprimirEstante();
            break;
        case 3:
            Console.WriteLine("Informe o índice do livro: ");
            BuscarLivro(int.Parse(Console.ReadLine()));
            break;
        case 4:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;

    }
}while(true);
Console.ReadLine();


