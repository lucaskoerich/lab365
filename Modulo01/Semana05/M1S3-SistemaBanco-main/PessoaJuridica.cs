namespace M1S3_SistemaBanco;

public class PessoaJuridica : Cliente
{

    public string CNPJ { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public List<PessoaFisica> Socios { get; set; } = new List<PessoaFisica>();
    public DateTime DataAbertura { get; set; }
    
    public static Cliente CriarConta()
    {

        PessoaJuridica empresa = new PessoaJuridica();
        
        empresa.DataAbertura = DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"A data de abertura da empresa é {empresa.DataAbertura}");
        Console.WriteLine("Qual a Razão Social");
        pessoa.Nome = Console.ReadLine();
        Console.WriteLine("CPF do cliente:");
        pessoa.CPF = Console.ReadLine();
        Console.WriteLine("Endereco do cliente:");
        pessoa.Endereco = Console.ReadLine();
        Console.WriteLine("Telefone do cliente:");
        pessoa.Telefone = Console.ReadLine();
        Console.WriteLine("Email do cliente:");
        pessoa.Email = Console.ReadLine();
        Console.WriteLine("Numero Da Conta");
        pessoa.NumeroConta = int.Parse(Console.ReadLine());

        return pessoa;
    }


}