namespace EstacionamentoPareAqui;

public class Carro
{
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public string Marca { get; set; }
    public List<Ticket> Tickets { get; set; }
    

    public Carro()
    {
        Tickets = new List<Ticket>();
    }
}