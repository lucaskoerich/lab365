namespace FSBankAPI.Models;

public class PessoaJuridica : Cliente
{

    public string CNPJ { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    //public List<string> Socios { get; set; } = new List<string>();
    public DateTime DataAbertura { get; set; }

    public PessoaJuridica(string email, string telefone, string endereco, int numeroConta, List<Transacao> extrato, string cnpj, string razaoSocial, string nomeFantasia, DateTime dataAbertura) : base(email, telefone, endereco, numeroConta, extrato)
    {
        CNPJ = cnpj;
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        DataAbertura = dataAbertura;
    }

    // public static Cliente AbrirEmpresa()
    // {
    //
    //     PessoaJuridica empresa = new PessoaJuridica();
    //     
    //     Console.WriteLine("Qual a data de abetura da empresa?");
    //     empresa.DataAbertura = DateTime.Parse(Console.ReadLine());
    //     Console.WriteLine($"A data de abertura da empresa é {empresa.DataAbertura}");
    //     Console.WriteLine("Qual a Razão Social");
    //     empresa.RazaoSocial = Console.ReadLine();
    //     Console.WriteLine("Qual será o CNPJ?");
    //     empresa.CNPJ = Console.ReadLine();
    //     Console.WriteLine("Qual será o Nome Fantasia?");
    //     empresa.NomeFantasia = Console.ReadLine();
    //     Console.WriteLine("Qual será o telefone da empresa?");
    //     empresa.Telefone = Console.ReadLine();
    //     Console.WriteLine("Qual será o e-mail da empresa?");
    //     empresa.Email = Console.ReadLine();
    //     Console.WriteLine("Qual será o número da conta");
    //     empresa.NumeroConta = int.Parse(Console.ReadLine());
    //     Console.WriteLine("Quantos sócios terão a empresa?");
    //     var op = int.Parse(Console.ReadLine());
    //
    //     
    //     for (int i = 0; i < op; i++)
    //     {
    //         Console.WriteLine($"Digite o CPF do #{i+1} sócio:");
    //         empresa.Socios.Add(Console.ReadLine());
    //     }
    //     
    //
    //     return empresa;
    // }
    

    public override string ResumoCliente()
    {

        string resumo = $"{NumeroConta}  |  {RazaoSocial}  |  {NomeFantasia}  |  {CNPJ}";
        
        return resumo;
       
    }

}