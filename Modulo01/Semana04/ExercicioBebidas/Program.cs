using ExercicioBebidas;

int op = Menu.MostrarMenu();

switch (op)
{
    case 1:

    {
        Console.WriteLine("Que tipo de bebida deseja adicionar?");
        Console.WriteLine("1 - Bebida comum");
        Console.WriteLine("2 - Refrigerante");
        Console.WriteLine("3 - Suco");
        var opc = Console.ReadLine();

        if (opc == "1")
        {
            Bebida bebida = new Bebida();
            Repositorio.AdicionarBebida(bebida);
        }
        else if (opc == "2")
        {
            Refrigerante refrigerante = new Refrigerante();
            Repositorio.AdicionarRefrigerante(refrigerante);
        }
        else if (opc == "3")
        {
            Suco suco = new Suco();
            Repositorio.AdicionarSuco(suco);
        }
        else
        {
            Console.WriteLine("Opção incorreta!");
        }
    }
        break;

    case 2:
    {
        Repositorio.AlterarBebida();
    }
        break;

    case 3:
    {
        Console.WriteLine("Insira o ID da bebida que deseja remover");
        Repositorio.ExcluirBebida(int.Parse(Console.ReadLine()));
    }
        break;

    case 4:
    {
        Repositorio.ListarTodasBebidas();
    }
        break;

    case 5:
    {
        op = 5;
    }
        break;
}
