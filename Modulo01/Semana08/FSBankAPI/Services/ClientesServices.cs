using FSBankAPI.Controllers;
using FSBankAPI.Models;

namespace FSBankAPI.Services;

public class ClienteService
{
    static List<Cliente> _clientes = new();

    public void CriarConta(Cliente cliente)
    {
        _clientes.Add(cliente);
    }


    // public Cliente BuscarCliente()
    // {
    //     Console.WriteLine("Digite o número da conta");
    //     var op = int.Parse(Console.ReadLine());
    //
    //     var cliente = clientes.Find(x => x.NumeroConta == op);
    //     return cliente;
    // }
    //
    public List<Cliente> ExibirClientes()
    {
        return _clientes;
    }

    public Cliente ExibirClientesPorId(int id)
    {
        Console.WriteLine(_clientes.Find(x => x.NumeroConta == id));
        return _clientes.Find(x => x.NumeroConta == id);
    }
}