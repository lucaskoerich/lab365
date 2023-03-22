namespace BasicAPI.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public Cliente(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}