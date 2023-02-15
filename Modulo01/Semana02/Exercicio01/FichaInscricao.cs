using System.Globalization;

namespace Exercicio01;

public class FichaInscricao
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public bool MenorIdade { get; set; }

    public void MostrarClasse()
    {
        Console.WriteLine($"Código: {Id}, Nome: {Nome}, Data de nascimento: {DataNascimento}");
    }
}