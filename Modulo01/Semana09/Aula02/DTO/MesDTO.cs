namespace Aula02.DTO;

public class MesDTO
{
    public int Codigo { get; set; }
    public DateTime DataHoraEvento { get; set; }
}
public class MesUpdateDTO
{
    public int Codigo { get; set; }
    public DateTime DataHoraEvento { get; set; }
}

public class MesGetAllDTO
{
    public int Id { get; set; }
    public string Mes { get; set; }
    public int Ano { get; set; }
}

