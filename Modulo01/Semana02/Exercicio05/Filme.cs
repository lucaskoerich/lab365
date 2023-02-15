namespace Exercicio05;

public class Filme
{
    public string NomeFilme { get; set; }
    public string Categoria { get; set; }

    public Filme(string nomeFilme, string categoria)
    {
        NomeFilme = nomeFilme;
        Categoria = categoria;
    }

    public void ExibirFilme()
    {
        Console.WriteLine($"Filme: {NomeFilme}. Categoria: {Categoria}");
    }
}