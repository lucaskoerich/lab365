namespace ExercicioBebidas;

public class Refrigerante : Bebida
{
    public Boolean Vidro { get; set; }

    public void ImprimirDados()
    {
        if (Vidro)
        {
            Console.WriteLine($"O produto com ID {Id} se chama {NomeBebida}. É um refrigerante de {Mililitro} ml em embalagem de vidro");
        }
        else
        {
            Console.WriteLine($"O produto com ID {Id} se chama {NomeBebida}. É um refrigerante de {Mililitro} ml em embalagem de plástico");

        }
    }
}