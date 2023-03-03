namespace M1S3_SistemaBanco;

public class PessoaFisica : Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }
    public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set {} }
    
    
    public string ResumoCliente()
    {
        return $"{NumeroConta} |  {Nome}  | {CPF}";
        
    }
    public bool EhMaior()
    {
        return Idade >= 18;
    }
    
    public static Cliente CriarConta()
    {

        PessoaFisica pessoa = new PessoaFisica();
        
        Console.WriteLine("Data de Nascimento do cliente:");
        pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());
        if(!pessoa.EhMaior()){
            Console.WriteLine("não é possivel abrir a conta pois o cliente é menor de idade");
            return null;
        }
        Console.WriteLine("A idade do cliente é " + pessoa.Idade);
        Console.WriteLine("Nome do cliente:");
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