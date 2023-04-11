namespace Aula02.DTO;

public class MesSemanaGetDTO
{
    public int IdMes { get; set; }
    public string Mes { get; set; }
    public List<MesSemanaGetDTO> SemanaGetDtos { get; set; }
}

public class SemanaGetDTO
{
    public int IdSemana { get; set; }
    public int Dia { get; set; }
    public string Observacao { get; set; }
    
}