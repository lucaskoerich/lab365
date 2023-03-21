namespace Aula01;

public class Cartao
{
    protected double _saldo { get; set; }

    public virtual void Debitar(double valor)
    {
        _saldo -= valor;
    }

    public virtual void Creditar(double valor)
    {
        _saldo += valor;
    }
    
    public void MostrarSaldo()
    {
        Console.WriteLine(_saldo);
    }

   
    
}