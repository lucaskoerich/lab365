using System;

namespace Exercicio_Semana.DTOS;

public class CarroDto
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string DescricaoCarro { get; set; }
    public int CodigoMarca { get; set; }
    public DateTime DataLocacao { get; set; }
}