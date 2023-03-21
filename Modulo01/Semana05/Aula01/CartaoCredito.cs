namespace Aula01;

public class CartaoCredito : Cartao
{
    public override void Creditar(double valor)
    {
        _saldo -= valor;
    }

    public override void Debitar(double valor)
    {
        _saldo += valor;
    }
}