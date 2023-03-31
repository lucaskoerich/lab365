using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Exercicio_Api.Models;

[Table("SEMANA")]
public class SemanaModel
{
    [Key]
    public int Id { get; set; }
    
    [NotNull]
    public DateTime DataSemana { get; set; }
    
    [MaxLength(100)]
    public string Conteudo { get; set; }
    
    [NotNull]
    public bool AplicadoConteudo { get; set; }
    
}