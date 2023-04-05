using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aula02.Models;

[Table("SEMANA")]
public class SemanaModel
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("MesModel")]
    public int IdMes { get; set; }
    
    public int Dia { get; set; }
    
    [ForeignKey("MesModel")]
    public MesModel Mes { get; set; }

}