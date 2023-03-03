using System.Globalization;
using M1S3_SistemaBanco;

List<Cliente> clientes = new List<Cliente>();

string opcao;
do
{
    Console.WriteLine("Bem vindos ao Banco FULL STACK BANCK, escolha uma opção");
    Console.WriteLine("1 - Criar Conta ");
    Console.WriteLine("2 - Adicionar Transacao");
    Console.WriteLine("3 - Consultar Extrato");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("5 - Exibir Clientes");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.WriteLine("Você deseja abrir conta para pessoa Física ou Jurídica?");
        Console.WriteLine("1 - Física");
        Console.WriteLine("2 - Jurídica");

        var op = Console.ReadLine();

        if (op == "1")
        {
            var cliente = PessoaFisica.CriarConta();
            clientes.Add(cliente);
        }

        if (op == "2")
        {
            
        }
    }
    else if (opcao == "5")
    {
        ExibirClientes();
    }
    else if (opcao == "2")
    {
        AdicionarTransacao();
    }
    else if (opcao == "3")
    {
        ExibirExtrato();
    }

    Console.WriteLine("Tecle Enter para continuar");
    Console.ReadLine();
} while (opcao != "4");


void AdicionarTransacao()
{
    Console.WriteLine("Qual a conta?");
    int numeroConta = int.Parse(Console.ReadLine());

    Cliente contaCliente = BuscarClientePorNumeroDeConta(numeroConta);

    if (contaCliente == null)
    {
        Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
        return;
    }

    Console.WriteLine("Qual o valor da transação?");
    double valor = double.Parse(Console.ReadLine());
    Transacao transacao = new Transacao(DateTime.Now, valor);

    contaCliente.Extrato.Add(transacao);
}

void ExibirExtrato()
{
    Console.WriteLine("Qual a conta?");
    int numeroConta = int.Parse(Console.ReadLine());

    Cliente contaCliente = BuscarClientePorNumeroDeConta(numeroConta);

    if (contaCliente == null)
    {
        Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
        return;
    }

    double saldo = 0;
    foreach (Transacao transacao in contaCliente.Extrato)
    {
        Console.WriteLine(" Data: " + transacao.Data + " Valor: " +
                          transacao.Valor.ToString("C2", new CultureInfo("pt-BR")));
        saldo += transacao.Valor;
        //Console.WriteLine($"Data: {transacao.Data} Valor: R$  {transacao.Valor}" );
    }

    Console.WriteLine("Saldo = " + contaCliente.Saldo);
}


Cliente BuscarClientePorNumeroDeConta(int numeroConta)
{
    ;
    foreach (Cliente cliente in clientes)
    {
        if (cliente.NumeroConta == numeroConta)
        {
            return cliente;
        }
    }

    // mesma coisa que o foreach
    // for(int i =0; i < clientes.Count; i++){
    //    if(clientes[i].NumeroConta == numeroConta);
    //     return clientes[i];
    // }
    return null;
}

void ExibirClientes()
{
    Console.WriteLine("Número da conta        | Nome         | CPF    ");
    for (int i = 0; i < clientes.Count; i++)
    {
        Console.WriteLine(clientes[i].ResumoCliente());
    }
}