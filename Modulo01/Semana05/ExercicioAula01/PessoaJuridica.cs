namespace ExercicioAula01;

public class PessoaJuridica : Cliente
{
    private string razaoSocial;
    private string CNPJ;

    public PessoaJuridica(string endereco, string id, string razaoSocial, string cnpj) : base(endereco, id)
    {
        this.razaoSocial = razaoSocial;
        CNPJ = cnpj;
    }

    public override void ExibirCliente()
    {
        Console.WriteLine($"ID: {id}. Endereço: {endereco}. Razão Social: {razaoSocial}. CNPJ: {CNPJ}");
        
    }
}