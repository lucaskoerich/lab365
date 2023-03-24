namespace FSBankAPI.Models;
public class Transacao
{
    public DateTime Data { get; set; }
    public double Valor { get; set; }

    public Transacao(DateTime data, double valor)
    {
        Data = data;

        Valor = valor;
    }
}