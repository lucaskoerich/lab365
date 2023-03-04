namespace ExercicioAula01;

public class PessoaFisica : Cliente
{
    private string nome;
    private string CPF;

    public PessoaFisica(string endereco, string id, string nome, string cpf) : base(endereco, id)
    {
        this.nome = nome;
        CPF = cpf;
    }

    public override void ExibirCliente()
    {
        Console.WriteLine($"ID: {id}. Endereço: {endereco}. Nome: {nome}. CPF: {CPF}");     
    }
    
}
