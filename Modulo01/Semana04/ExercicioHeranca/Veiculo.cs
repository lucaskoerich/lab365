namespace ExercicioHeranca;

public class Veiculo
{
    public int Id { get; set; }
    public double Km { get; set; }
    public string Cor { get; set; }
    public double Velocidade { get; set; }
    public string TipoVeiculo { get; set; }


    public void Acelerar(double velocidade)
    {
        Velocidade += velocidade;
    }

    public void Parar()
    {
        Velocidade = 0.0;
    }

    public void ImprimirVeiculo()
    {
        Console.WriteLine(TipoVeiculo);
    }
}