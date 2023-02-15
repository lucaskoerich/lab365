namespace Exercicio03;

public class Guitarra
{
    private static string _afinacao;

    static Guitarra()
    {
        _afinacao = "SOL";
    }

    private void TomAfinado()
    {
        Console.WriteLine($"A guitarra está com afinação em {_afinacao}");
    }

    public void Tocar()
    {
        TomAfinado();
    }

    public void Tocar(string afinacaoAtual)
    {
        _afinacao = afinacaoAtual;
        TomAfinado();
    }
}