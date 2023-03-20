namespace ExercicioBebidas;

public class Suco : Bebida
{
    public string Embalagem { get; set; }

    public void ImprimirDados()
    {
        Console.WriteLine($"O produto com ID {Id} é um suco com embalagem de {Embalagem} contendo {Mililitro} ml");
    }
}