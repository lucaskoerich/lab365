namespace Aula01;

public class CartaoDebito : Cartao
{
    public void Debitar(double valor)
    {
        _saldo -= valor;
    }

    public void Creditar(double valor)
    {
        _saldo += valor;
    }
}