namespace ExercicioBebidas;

public static class Repositorio
{
    private static List<Bebida> bebidas = new List<Bebida>();
    private static List<Suco> sucos = new List<Suco>();
    private static List<Refrigerante> refrigerantes = new List<Refrigerante>();
    public static List<Bebida> Bebida => bebidas;
    public static List<Suco> Suco => sucos;
    public static List<Refrigerante> Refrigerante => refrigerantes;


    public static void AdicionarSuco(Suco suco)
    {
        Console.WriteLine("Cadastrando novo suco");
        Console.WriteLine("Qual é o nome do suco?");
        suco.NomeBebida = Console.ReadLine();

        Console.WriteLine("Qual será o ID?");
        suco.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual é a embalagem?");
        suco.Embalagem = Console.ReadLine();

        Console.WriteLine("Quantos ml contém a embalagem?");
        suco.Mililitro = decimal.Parse(Console.ReadLine());

        suco.Tipo = "1";

        Suco.Add(suco);
    }

    public static void AdicionarRefrigerante(Refrigerante refrigerante)
    {
        Console.WriteLine("Cadastrando novo refrigerante");
        Console.WriteLine("Qual é o nome do refrigerante?");
        refrigerante.NomeBebida = Console.ReadLine();

        Console.WriteLine("Qual será o ID?");
        refrigerante.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("A embalagem é de vidro? s/n");
        var emb = Console.ReadLine();
        if (emb == "s")
        {
            refrigerante.Vidro = true;
        }
        else
        {
            refrigerante.Vidro = false;
        }

        Console.WriteLine("Quantos ml contém a embalagem?");
        refrigerante.Mililitro = decimal.Parse(Console.ReadLine());

        refrigerante.Tipo = "2";


        Refrigerante.Add(refrigerante);
    }

    public static void AdicionarBebida(Bebida bebida)
    {
        Console.WriteLine("Cadastrando nova bebida");
        Console.WriteLine("Qual é o nome da bebida?");
        bebida.NomeBebida = Console.ReadLine();

        Console.WriteLine("Qual será o ID?");
        bebida.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantos ml contém a embalagem?");
        bebida.Mililitro = decimal.Parse(Console.ReadLine());

        bebida.Tipo = "0";

        Bebida.Add(bebida);
    }

    public static void AlterarBebida()
    {
        Console.WriteLine("Qual tipo de bebida deseja alterar? \n");
        Console.WriteLine("Bebida comum == 0");
        Console.WriteLine("Suco == 1");
        Console.WriteLine("Refrigerante == 2 \n");
        var tipo = int.Parse(Console.ReadLine());

        if (tipo < 0 || tipo > 2)
        {
            Console.WriteLine("Tipo não encontrado");
            return;
        }

        Console.WriteLine("Digite o ID da bebida:");
        var id = int.Parse(Console.ReadLine());


        if (tipo == 0)
        {
            foreach (var item in Repositorio.Bebida)
            {
                if (item.Id == id)
                {
                    var nomeAntigo = item.NomeBebida;
                    Console.WriteLine($"Novo nome para {item.NomeBebida}");
                    item.NomeBebida = Console.ReadLine();
                    Console.WriteLine($"Nome de {nomeAntigo} alterado para {item.NomeBebida} \n");


                    return;
                }
            }
        }

        if (tipo == 1)
        {
            foreach (var item in Repositorio.Suco)
            {
                if (item.Id == id)
                {
                    var nomeAntigo = item.NomeBebida;
                    Console.WriteLine($"Novo nome para {item.NomeBebida}");
                    item.NomeBebida = Console.ReadLine();
                    Console.WriteLine($"Nome de {nomeAntigo} alterado para {item.NomeBebida} \n");


                    return;
                }
            }
        }

        if (tipo == 2)
        {
            foreach (var item in Repositorio.Refrigerante)
            {
                if (item.Id == id)
                {
                    var nomeAntigo = item.NomeBebida;
                    Console.WriteLine($"Novo nome para {item.NomeBebida}");
                    item.NomeBebida = Console.ReadLine();
                    Console.WriteLine($"Nome de {nomeAntigo} alterado para {item.NomeBebida} \n");


                    return;
                }
            }
        }
    }


    public static void ExcluirBebida(int id)
    {
        foreach (var item in Repositorio.Bebida)
        {
            if (item.Id == id)
            {
                bebidas.Remove(item);
                return;
            }
        }
    }

    public static void ListarTodasBebidas()
    {
        foreach (var item in Repositorio.Bebida)
        {
            Console.WriteLine($"Nome: {item.NomeBebida}");
            Console.WriteLine($"ID: {item.Id}");
            Console.WriteLine($"ML: {item.Mililitro}");
            Console.WriteLine("\n");
        }

        foreach (var item in Repositorio.Refrigerante)
        {
            Console.WriteLine($"Nome: {item.NomeBebida}");
            Console.WriteLine($"ID: {item.Id}");
            Console.WriteLine($"ML: {item.Mililitro}");
            if (item.Vidro)
            {
                Console.WriteLine("Tipo de embalagem: Vidro \n");
            }
            else
            {
                Console.WriteLine("Tipo de embalagem: Plástico \n");
            }
        }

        foreach (var item in Repositorio.Suco)
        {
            Console.WriteLine($"Nome: {item.NomeBebida}");
            Console.WriteLine($"ID: {item.Id}");
            Console.WriteLine($"ML: {item.Mililitro} \n");
        }
    }
}