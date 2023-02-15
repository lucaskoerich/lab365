namespace Exercicio07;

public class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }

    public Pessoa(string nome, DateTime dataNascimento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
    }

    private int CalcularIdade()
    {
        var dataAtual = DateTime.Now;
        var idade = dataAtual.Year - DataNascimento.Year;
        if (DataNascimento > dataAtual.AddYears(-idade))
        {
            idade--;
        }

        return idade;
    }

    public void MostrarIdade()
    {
        Console.WriteLine($"Nome: {Nome}. Idade {CalcularIdade()}");
    }
}