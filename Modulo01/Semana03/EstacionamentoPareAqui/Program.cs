using EstacionamentoPareAqui;

List<Carro> carros = new List<Carro>();

Console.WriteLine("Bem-vindo ao Estacionamento Pare Aqui");
string opcao;

do
{
    Console.WriteLine("Escolha uma opção do menu:");
    Console.WriteLine("1 - Cadastrar carro");
    Console.WriteLine("2 - Marcar entrada");
    Console.WriteLine("3 - Marcar saída");
    Console.WriteLine("4 - Consultar histórico");
    Console.WriteLine("5 - Sair");

    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        CadastrarCarro();
    }

    if (opcao == "2")
    {
        GerarTicket();
    }

    if (opcao == "3")
    {
        FecharTicket();
    }

    if (opcao == "4")
    {
        Historico();
    }
} while (opcao != "5");


void CadastrarCarro()
{
    Carro carro = new Carro();

    Console.WriteLine("Qual a placa do carro?");
    carro.Placa = Console.ReadLine();

    Console.WriteLine("Qual o modelo do carro?");
    carro.Modelo = Console.ReadLine();

    Console.WriteLine("Qual a cor do carro?");
    carro.Cor = Console.ReadLine();

    Console.WriteLine("Qual a marca do carro?");
    carro.Marca = Console.ReadLine();

    carros.Add(carro);
}

Carro ObterCarro(string placa)
{
    foreach (var carro in carros)
    {
        if (placa == carro.Placa)
        {
            return carro;
        }
    }

    return null;
}

void GerarTicket()
{
    Console.WriteLine("Qual a placa do carro?");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);
    {
        if (carro == null)
        {
            Console.WriteLine("Carro não cadastrado no sistema");
            return;
        }

        foreach (var ticket in carro.Tickets) 
        {
            if (ticket.Ativo)
            {
                Console.WriteLine("Veículo já está estacionado"); 
                return; 
            }
        }
    }
    
    Ticket ticketNovo = new Ticket();
    carro.Tickets.Add(ticketNovo);
    Console.WriteLine("Ticket Gerado!"); 
}

void FecharTicket()
{
    Console.WriteLine("Qual a placa do veículo");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);
    if(carro == null){
        Console.WriteLine("Carro não cadastrado"); 
        return; 
    }

    Ticket ticketAberto = null;
    
    foreach(var ticket in carro.Tickets){
        if(ticket.Ativo){
            ticketAberto = ticket;
        }
    }
    if(ticketAberto == null){
        Console.WriteLine("Não há tickets em aberto para o veículo"); 
        return; 
    }  

    ticketAberto.FecharTicket();
}

void Historico(){
    Console.WriteLine("Qual a placa do veículo");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);
    if(carro == null){
        Console.WriteLine("Carro não cadastrado"); 
        return; 
    }

    Console.WriteLine("Entrada              |Saída                 |Ativo   | Valor ");

    foreach(var ticket in carro.Tickets){
        if (ticket.Ativo ==true){
            Console.WriteLine($"{ticket.Entrada} | -------------------- | { ticket.Ativo.ToString()} | R$--,--");
        }
        else {
            Console.WriteLine($"{ticket.Entrada} | {ticket.Saida} | { ticket.Ativo.ToString()} | R${ticket.CalcularValor()}");
        }
    }
}