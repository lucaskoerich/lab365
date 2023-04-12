using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercicio_Semana.Models;

[Table("CARROS")]
public class CarroModel
{
    [Column ("ID"), Key] public int Id { get; set; }

    [Column("NOME"), Required] public string Nome { get; set; }

    [Column("ID_MARCA"), ForeignKey("MarcaModel")]public int IdMarca { get; set; }

    [Column("DATA_LOCACAO")] public DateTime DataLocacao { get; set; }
    public MarcaModel MarcaModel { get; set; }
}