namespace M1S3_SistemaBanco;

public interface IClienteService
{
    void CriarConta();
    Cliente BuscarCliente();
    void ExibirClientes();
}