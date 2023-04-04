using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Aula02.Models;

[Table("MES")]
public class MesModel
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }
    
    [MaxLength(100)]
    public string Nome { get; set; }
    
    public int Ano { get; set; }
    
}