namespace ExercicioHeranca;

public class Carro : Veiculo

{
    public bool Airbag { get; set; }
    public bool Radio { get; set; }
    public bool CameraRe { get; set; }
    

    public void Eixo()
    {
        Console.WriteLine("eixo?");
    }
}