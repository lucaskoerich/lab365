namespace ExercicioHeranca;

public class Moto : Veiculo
{
    public bool Bau { get; set; }
    public bool AntenaLinhaPipa { get; set; }
    public bool Capacete { get; set; }

    public void PilotoComCapacete(bool capacete)
    {
        Capacete = capacete;
        
    }
    public void CapaDeChuva()
    {
        
        
    }
    
}