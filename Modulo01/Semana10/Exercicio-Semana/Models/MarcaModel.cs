using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercicio_Semana.Models;

[Table("MARCAS")]
public class MarcaModel
{
    [Column("ID"), Key] public int Id { get; set; }

    [Column("NOME"), Required] public string Nome { get; set; }
}