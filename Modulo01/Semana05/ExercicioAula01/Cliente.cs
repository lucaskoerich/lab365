namespace ExercicioAula01;

public abstract class Cliente
{
    protected string endereco;
    protected string id;

    protected Cliente(string endereco, string id)
    {
        this.endereco = endereco;
        this.id = id;
    }

    public virtual void ExibirCliente()
    {
        Console.WriteLine($"ID: {1}. Endereço: {2}", id, endereco); 
    }
}