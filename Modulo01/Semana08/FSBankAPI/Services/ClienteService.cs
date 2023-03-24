using FSBankAPI.Controllers;
using FSBankAPI.Interfaces;
using FSBankAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FSBankAPI.Services;

public class ClienteService : IClientesService
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

    public Cliente BuscarCliente(int id)
    {
        return _clientes.Find(x => x.NumeroConta == id);
    }

    public void DeletarCliente(int id)
    {
        _clientes.Remove(BuscarCliente(id));
    }

    public Cliente AtualizarPessoaFisica(PessoaFisica pessoaFisica, int id)
    {
        PessoaFisica newPessoaFisica = BuscarCliente(id) as PessoaFisica;

        if (pessoaFisica != null)
        {
            newPessoaFisica.Email = pessoaFisica.Email;
            newPessoaFisica.Telefone = pessoaFisica.Telefone;
            newPessoaFisica.Endereco = pessoaFisica.Endereco;
            newPessoaFisica.Nome = pessoaFisica.Nome;
            newPessoaFisica.CPF = pessoaFisica.CPF;
            newPessoaFisica.DataNascimento = pessoaFisica.DataNascimento;
        }

        return newPessoaFisica;
    }

    public Cliente AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica, int id)
    {
        PessoaJuridica newPessoaJuridica = BuscarCliente(id) as PessoaJuridica;

        if (newPessoaJuridica != null)
        {
            newPessoaJuridica.Email = pessoaJuridica.Email;
            newPessoaJuridica.Telefone = pessoaJuridica.Telefone;
            newPessoaJuridica.Endereco = pessoaJuridica.Endereco;
            newPessoaJuridica.RazaoSocial = pessoaJuridica.RazaoSocial;
            newPessoaJuridica.NomeFantasia = pessoaJuridica.NomeFantasia;
            newPessoaJuridica.CNPJ = pessoaJuridica.CNPJ;
            newPessoaJuridica.DataAbertura = pessoaJuridica.DataAbertura;
        }

        return newPessoaJuridica;
    }

    public void AdicionarTransacao(Transacao transacao, int idCliente)
    {
        Cliente cliente = BuscarCliente(idCliente);

        cliente.Extrato.Add(transacao);
    }

    public List<Transacao> ListarTransacao(int idCliente)
    {
        Cliente cliente = BuscarCliente(idCliente);

        return cliente.Extrato;
    }
}