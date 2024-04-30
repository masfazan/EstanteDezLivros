using System.ComponentModel.Design;

int cadastro = 0;
int resposta;
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
            Console.WriteLine("Gostaria de incluir mais um?\nDigite: 1-para sim e 2-para não");
            resposta = int.Parse(Console.ReadLine());
            switch (resposta)
            {
                case 1:
                    livros[cadastro] = InserirLivro();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    } while (true);
    
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
    switch (Menu())
    {
        case 1:
            AdicionarLivroEstante();
            break;
        case 2:
            ImprimirEstante();
            break;
        case 3:
            int posicao = 0;
            do {
                Console.WriteLine("Informe o índice do livro: ");
                posicao = (int.Parse(Console.ReadLine()));
                if (posicao > cadastro || posicao == 0)
                {
                    Console.WriteLine("Não há livros cadastrados no índice informado!");
                }
            } while (posicao > cadastro || posicao == 0);
            BuscarLivro(posicao);
            break;
        case 4:
            Console.WriteLine("Saindo...");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;

    }
} while (true);
Console.ReadLine();


