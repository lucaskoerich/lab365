namespace Exercicio02;

public class MensagemCelular
{
    public int Telefone { get; set; }
    public string Mensagem { get; set; }

    public MensagemCelular(int telefone, string mensagem)
    {
        Telefone = telefone;
        Mensagem = mensagem;
    }

    private void EnviarMensagemAoTelefone()
    {
        Console.WriteLine("Método privado executado na classe");
        Console.WriteLine($"Telefone: {Telefone}. Mensagem: {Mensagem}");
    }

    public void Executar()
    {
        Console.WriteLine("Método público executado na classe");
        EnviarMensagemAoTelefone();
    }
}