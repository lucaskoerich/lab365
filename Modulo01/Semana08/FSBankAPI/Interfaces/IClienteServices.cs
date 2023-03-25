using FSBankAPI.Models;

namespace FSBankAPI.Interfaces;

public interface IClientesServices
{
    void CriarConta(Cliente cliente);
    List<Cliente> ExibirClientes();
    Cliente BuscarCliente(int id);
    Cliente AtualizarPessoaFisica(PessoaFisica pessoaFisica, int id);
    Cliente AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica, int id);
    void DeletarCliente(int id);
    void AdicionarTransacao(Transacao transacao, int idCliente);
    List<Transacao> ListarTransacao(int idCliente);
}