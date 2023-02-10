Console.WriteLine("Bem-vindo ao Banco Nacional Coqueiros!");
Console.WriteLine("Por favor selecione uma opção para continuar: ");

List<double> transacao = new List<double>();
double saldo = 0;
bool sair = false;

do
{
    Console.WriteLine("1. Adicionar transação");
    Console.WriteLine("2. Consultar extrato");
    Console.WriteLine("3. Sair");

    int opcao = int.Parse(Console.ReadLine());
    sair = false;

    if (opcao == 1)
    {
        Console.WriteLine("Digite o valor para depósito ou saque:");
        double valor = double.Parse(Console.ReadLine());
        transacao.Add(valor);
        saldo += valor;
    }
    else if (opcao == 2)
    {
        for (int i = 0; i < transacao.Count; i++)
        {
            Console.WriteLine($"Transação {i + 1} = {transacao[i]}");
        }

        Console.WriteLine($"Saldo = {saldo}");
    }
    else if (opcao == 3)
    {
        sair = true;
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
} while (sair == false);